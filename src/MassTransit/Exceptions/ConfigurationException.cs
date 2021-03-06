// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Exceptions
{
	using System;
	using System.Runtime.Serialization;
	using Configurators;

	[Serializable]
	public class ConfigurationException :
		MassTransitException
	{
		public ConfigurationException()
		{
		}

		public ConfigurationException(ConfigurationResult result, string message)
			: base(message)
		{
			Result = result;
		}

		public ConfigurationException(ConfigurationResult result, string message, Exception innerException)
			: base(message, innerException)
		{
			Result = result;
		}

		public ConfigurationException(string message)
			: base(message)
		{
		}

		public ConfigurationException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected ConfigurationException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public ConfigurationResult Result { get; protected set; }
	}
}