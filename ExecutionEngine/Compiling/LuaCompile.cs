using System;

namespace ExecutionEngine
{
	public class LuaCompile : ICompiler
	{
		public LuaCompile ()
		{
		}

		#region ICompiler implementation
		public CompilerData Compile (InputData idata, CompilerData cdata)
		{
			cdata.ExecuteThis = idata.PathToSource;
			cdata.Executor = "lua";
			cdata.Success = true;
			return cdata;
		}
		#endregion
	}
}

