/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class GetOssPropertiesResponse : AcsResponse
	{

		private string requestId;

		private GetOssProperties_Result result;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public GetOssProperties_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class GetOssProperties_Result
		{

			private string endpoint;

			private string accessKeyId;

			private string accessKeySecret;

			private string bucketName;

			private string folderName;

			public string Endpoint
			{
				get
				{
					return endpoint;
				}
				set	
				{
					endpoint = value;
				}
			}

			public string AccessKeyId
			{
				get
				{
					return accessKeyId;
				}
				set	
				{
					accessKeyId = value;
				}
			}

			public string AccessKeySecret
			{
				get
				{
					return accessKeySecret;
				}
				set	
				{
					accessKeySecret = value;
				}
			}

			public string BucketName
			{
				get
				{
					return bucketName;
				}
				set	
				{
					bucketName = value;
				}
			}

			public string FolderName
			{
				get
				{
					return folderName;
				}
				set	
				{
					folderName = value;
				}
			}
		}
	}
}