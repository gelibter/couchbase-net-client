﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Membase.Configuration;

namespace Couchbase.Configuration
{
	/// <summary>
	/// Client configuration class.
	/// </summary>
	public class CouchbaseClientConfiguration : MembaseClientConfiguration, ICouchbaseClientConfiguration
	{
		/// <summary>
		/// Gets or sets the INameTransformer instance.
		/// </summary>
		public INameTransformer DesignDocumentNameTransformer { get; set; }

		INameTransformer ICouchbaseClientConfiguration.CreateDesignDocumentNameTransformer()
		{
			return this.DesignDocumentNameTransformer;
		}
	}
}

#region [ License information          ]
/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2011 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/
#endregion