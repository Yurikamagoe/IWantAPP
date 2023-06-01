using IWantApp.Infra.Data;

namespace IWantApp.Enpoints.Category;

public class CategoryPost
{
    public static string Template => "/categoiries";
    public static string[] Methods => new string[] { HttpMethod.Post.ToString()};
    public static Delegate Handle => Action;
    public static IResult Action(CategoryRequest categoryRequest, ApplicationDbContext context)
    {
        return Results.Ok("Ok");
    }
}
