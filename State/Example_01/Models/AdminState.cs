using DesignPatternPractice.State.Example_01.Interfaces;

namespace DesignPatternPractice.State.Example_01.Models;
public class AdminState : IUserState
{
    public void ApplyScore(Post post, User user)
    {
        post.Author.Reputation += 5;
    }  
}
