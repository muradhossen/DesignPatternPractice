using DesignPatternPractice.State.Example_01.Interfaces;

namespace DesignPatternPractice.State.Example_01.Models;
public class ScoringContext
{
    private IUserState _state;

    public ScoringContext(IUserState initialState)
    {
        _state = initialState;
    }
    public void SetState(IUserState state)
    {
        _state = state;  
    }

    public void ApplyScore(Post post, User user)
    {
        _state.ApplyScore(post, user);  
    }
}
