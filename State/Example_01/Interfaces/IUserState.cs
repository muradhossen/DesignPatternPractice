using DesignPatternPractice.State.Example_01.Models;

namespace DesignPatternPractice.State.Example_01.Interfaces;
public interface IUserState
{
    void ApplyScore(Post post, User user);
}
