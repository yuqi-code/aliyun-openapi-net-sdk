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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20180801;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudesl.Model.V20180801
{
    public class DescribeAlarmsRequest : RpcAcsRequest<DescribeAlarmsResponse>
    {
        public DescribeAlarmsRequest()
            : base("cloudesl", "2018-08-01", "DescribeAlarms")
        {
        }

		private string errorType;

		private string toAlarmTime;

		private string alarmType;

		private string fromAlarmTime;

		private string alarmId;

		private int? pageSize;

		private string storeId;

		private int? pageNumber;

		private string alarmStatus;

		public string ErrorType
		{
			get
			{
				return errorType;
			}
			set	
			{
				errorType = value;
				DictionaryUtil.Add(QueryParameters, "ErrorType", value);
			}
		}

		public string ToAlarmTime
		{
			get
			{
				return toAlarmTime;
			}
			set	
			{
				toAlarmTime = value;
				DictionaryUtil.Add(QueryParameters, "ToAlarmTime", value);
			}
		}

		public string AlarmType
		{
			get
			{
				return alarmType;
			}
			set	
			{
				alarmType = value;
				DictionaryUtil.Add(QueryParameters, "AlarmType", value);
			}
		}

		public string FromAlarmTime
		{
			get
			{
				return fromAlarmTime;
			}
			set	
			{
				fromAlarmTime = value;
				DictionaryUtil.Add(QueryParameters, "FromAlarmTime", value);
			}
		}

		public string AlarmId
		{
			get
			{
				return alarmId;
			}
			set	
			{
				alarmId = value;
				DictionaryUtil.Add(QueryParameters, "AlarmId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(QueryParameters, "StoreId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string AlarmStatus
		{
			get
			{
				return alarmStatus;
			}
			set	
			{
				alarmStatus = value;
				DictionaryUtil.Add(QueryParameters, "AlarmStatus", value);
			}
		}

        public override DescribeAlarmsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeAlarmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}