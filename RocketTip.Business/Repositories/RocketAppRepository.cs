using RocketTip.Business.ServiceCenter.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RocketTip.Business.Repositories
{
	public class RocketAppRepository
	{
		readonly HttpRequestHelper client;
		public RocketAppRepository()
		{
			this.client = new HttpRequestHelper();
		}

		//public async Task<LoginResponse> LoginAsync(string userName, string password)
		//{
		//	return await this.client.CreateGetResponse<LoginResponse>($"User/Login?userName={userName}&Password={password}");
		//}

		//public async Task<bool> ForgotPasswordAsync(string userName)
		//{
		//	return await this.client.CreateGetResponse<bool>($"User/ForgotPassword?userName={userName}");
		//}

		//public async Task<bool> RegistrationAsync(UserModel user)
		//{
		//	return await this.client.CreatePostRequest<bool>($"User", user);
		//}

	}
}
