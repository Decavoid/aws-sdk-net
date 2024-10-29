#if AWS_ASYNC_API || AWS_ASYNC_ENUMERABLES_API
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Amazon.Util.Internal
{
    public static class TaskExtensions
    {
#if AWS_ASYNC_API
        public static ConfiguredTaskAwaitable ConfigureAwaitEx(this Task task)
        {
            return task.ConfigureAwait(AWSConfigs.AsyncTasksContinueOnCapturedContext);
        }

        public static ConfiguredTaskAwaitable<TResult> ConfigureAwaitEx<TResult>(this Task<TResult> task)
        {
            return task.ConfigureAwait(AWSConfigs.AsyncTasksContinueOnCapturedContext);
        }
#endif

#if AWS_ASYNC_ENUMERABLES_API
        public static ConfiguredCancelableAsyncEnumerable<T> ConfigureAwaitEx<T>(this ConfiguredCancelableAsyncEnumerable<T> enumerable)
        {
            return enumerable.ConfigureAwait(AWSConfigs.AsyncTasksContinueOnCapturedContext);
        }
#endif
    }
}
#endif