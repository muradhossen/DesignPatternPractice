using DesignPatternPractice.State.Example_01.Models;

namespace DesignPatternPractice.State;
public class StateController : IController
{
    public void Execute()
    {
        var post = new Post { Author = new User { Reputation = 0 } };
        var adminUser = new User { IsAdmin = true };
        var nonAdminUser = new User { IsAdmin = false };

        // Admin scoring
        var scoringContext = new ScoringContext(new AdminState());
        scoringContext.ApplyScore(post, adminUser);

        // Non-admin scoring
        scoringContext.SetState(new NonAdminState());
        scoringContext.ApplyScore(post, nonAdminUser);

        // Output results
        Console.WriteLine($"Post Score: {post.Score}");
        Console.WriteLine($"Author Reputation: {post.Author.Reputation}");
    }
}
