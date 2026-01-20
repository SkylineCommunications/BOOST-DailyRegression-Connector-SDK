namespace Skyline.Protocol
{
    using SLNetMessages = Skyline.DataMiner.Net.Messages;

    namespace MyExtension
	{
		using Skyline.DataMiner.Scripting;

		public class MyClass
		{
			public MyClass(SLProtocol protocol)
			{
				var idx = new uint[]
				{
					Parameter.Mytable.Idx.mytable_instance,
					Parameter.Mytable.Idx.mytable_stringcolumn,
				};

				var columns = (object[])protocol.NotifyProtocol(
					(int)SLNetMessages.NotifyType.NT_GET_TABLE_COLUMNS,
					Parameter.Mytable.tablePid,
					idx);
			}
		}
	}
}