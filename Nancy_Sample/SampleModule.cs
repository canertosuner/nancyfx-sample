using Nancy;
using Nancy.ModelBinding;

namespace Nancy_Sample
{
public class SampleModule : NancyModule
{
    public SampleModule()
    {
        Get["/"] = parameters => "Que pasa primo !";


        Post["/sum"] = parameters =>
        {
            var request = this.Bind<SumRequestModel>();

            return new SumResponseModel { Result = request.X + request.Y };
        };


        Get["/home"] = parameters =>
        {
            return View["View/Home.cshtml"];
        };
    }
}

    public class SumRequestModel
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class SumResponseModel
    {
        public int Result { get; set; }
    }
}
