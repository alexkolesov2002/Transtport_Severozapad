using TTask.Library;

namespace TTask.Nav
{
    public abstract class NavMsg
    {
    }


    public class ToAlgorithmPage : NavMsg
    {

    }

    public class ToResultPage : NavMsg
    {
        public Output Output { get; }

        public ToResultPage(Output result)
        {
            Output = result;
        }
    }

    public class ToStartPage : NavMsg
    {

    }
}
