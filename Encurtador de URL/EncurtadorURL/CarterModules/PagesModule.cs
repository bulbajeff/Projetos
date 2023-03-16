using Carter;

namespace EncurtadorURL.CarterModules
{
    public class PagesModule : CarterModule
    {
        public PagesModule() 
        {
            Get("/", async (req, res) =>
            {
                await res.WriteAsync("Hello from Carter");
            });
        }
    }
}
