// URL: https://github.com/takakiwakuda/CSharp-Polyfill

#if !NETCOREAPP3_0_OR_GREATER
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    [DebuggerNonUserCode]
    [ExcludeFromCodeCoverage]
    [SuppressMessage("csharp", "IDE0060")]
    internal sealed class CallerArgumentExpressionAttribute : Attribute
    {
        internal CallerArgumentExpressionAttribute(string parameterName)
        {
        }
    }
}
#endif
