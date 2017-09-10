#include "player.h"
#include "world.h"
#include <GL/gl.h>
#include <SDL2/SDL.h>
#include <cmath>

static const float Gravity = 0.27f;
static const float JumpForce = 4.5f;
static const float JumpTimerMax = 16;
static const float MoveSpeed = 3.f;

Player::Player(World& world, float x, float y):
    od::AutoIndex<od::Object2d, Player>(x, y),
    rect(0, 0, 24, 48),
    world(&world)
{
}

const od::Shape* Player::collisionMask(int p) const
{
    return &rect;
}

void Player::step(float dt)
{
    const Uint8 *keystate = SDL_GetKeyboardState(NULL);
    
    bool key_left  = false;
    bool key_right = false;
    bool key_down  = false;
    bool key_jump  = false;
    
    // Client - manual
    key_left  = keystate[SDL_SCANCODE_LEFT ];
    key_right = keystate[SDL_SCANCODE_RIGHT];
    key_down  = keystate[SDL_SCANCODE_DOWN];
    key_jump  = keystate[SDL_SCANCODE_SPACE];
    
    /// @todo Client - pathfinding
    
    // add functions calls to the pathfinding here
    
    
    simulateOneFrame(dt, key_left, key_right, key_down, key_jump);
}

void Player::simulateOneFrame(float dt, bool key_left, bool key_right, bool key_down, bool key_jump)
{
    // Server - Should not be edited
    
    using namespace od;
    
    bool platforms_solid = false;
    if(!key_down)
        platforms_solid = true;
    
    if(world && platforms_solid)
    {
        od::Rect rect = boundingBox();
        
        world->platforms_enabled = true;
        
        float top    = std::floor(std::floor(rect.y1)/16);
        float bottom = std::ceil (std::floor(rect.y2)/16);
        float left   = std::floor(std::floor(rect.x1)/16);
        float right  = std::ceil (std::floor(rect.x2)/16);
        
        world->actor_top    = int(top);
        world->actor_bottom = int(bottom);
        world->actor_left   = int(left);
        world->actor_right  = int(right);
    }
    
    phys.vy += Gravity;
    
    if(phys.on_ground)
        phys.vy = 0;
    
    float force_x = 0;
    if(key_left ) force_x -= MoveSpeed;
    if(key_right) force_x += MoveSpeed;
    
    if(jump_state.jumped && phys.on_ground)
    {
        jump_state.jumped = false;
    }
    else if(key_jump)
    {
        if(jump_state.jumped && jump_state.jump_timer > 0)
        {
            float t = 1.f - jump_state.jump_timer / JumpTimerMax;
            t = 1 - t*t;
            phys.vy -= t * 0.35f * dt;
            jump_state.jump_timer -= dt;
        }
    }
    
    if(key_jump && phys.on_ground)
    {
        phys.vy = -JumpForce;
        jump_state.jump_timer = JumpTimerMax;
        jump_state.jumped = true;
    }

    if(jump_state.jump_timer > 0 && (phys.vy > 0.f || !key_jump))
        jump_state.jump_timer = 0;
    
    phys.update(dt, force_x, 0.f, *this);
    
    if(phys.col_left || phys.col_right) phys.vx = 0.f;
    if(phys.col_top || phys.col_bottom) phys.vy = 0.f;
    
    if(world)
        world->platforms_enabled = false;
}

void Player::draw() const
{
    glColor3ub(64, 128, 255);
    glBegin(GL_QUADS);
        glVertex2f(pos.x + rect.x1, pos.y + rect.y1);
        glVertex2f(pos.x + rect.x2, pos.y + rect.y1);
        glVertex2f(pos.x + rect.x2, pos.y + rect.y2);
        glVertex2f(pos.x + rect.x1, pos.y + rect.y2);
    glEnd();
    glColor3f(1, 1, 1);
}
