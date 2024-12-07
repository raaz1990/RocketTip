using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketTip.Business.ServiceCenter.Responses
{
	public class BaseResponse
	{
		public object Message { get; set; }
		public bool Success { get; set; }
		public int MessageType { get; set; }
		public object ApiToken { get; set; }
	}
}
