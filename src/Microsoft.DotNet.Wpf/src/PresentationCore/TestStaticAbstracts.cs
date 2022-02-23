using System.Runtime.Versioning;

namespace TestStaticAbstracts
{
    [RequiresPreviewFeatures]
    public interface ITestStaticAbstracts<T>
    {
        static abstract T Create();
    }

    public struct TestStaticAbstractsPass
    {
        public static int Create() => 5;
    }

    [RequiresPreviewFeatures]
    public struct TestStaticAbstractsFail : ITestStaticAbstracts<int>
    {
        public static int Create() => 42;
    }
}
