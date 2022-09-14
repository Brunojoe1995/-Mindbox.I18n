// Copyright 2022 Mindbox Ltd
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Mindbox.I18n.Abstractions;

public interface ILogger
{
#pragma warning disable CA1716
	void LogMissingNamespace(ILocale locale, string @namespace, string key);
	void LogMissingLocale(ILocale locale, string key);
	void LogMissingKey(ILocale locale, string @namespace, string key);
	void LogInvalidKey(string key);
	void LogInvalidOperation(string message);
	void LogError(Exception exception, string message);
#pragma warning restore CA1716
}