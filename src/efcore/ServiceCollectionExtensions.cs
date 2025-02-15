// Copyright 2022 - 2023 Godwin peter .O (me@godwin.dev)
// 
// Licensed under the MIT License;
// you may not use this file except in compliance with the License.
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.Extensions.DependencyInjection;
using Axolotl.EFCore.Repository;

namespace Axolotl.EFCore;

public static class ServiceCollectionExtensions {
    public static IServiceCollection RegisterGenericRepositories(this IServiceCollection services, Type repositoryType) {
        services.AddScoped(typeof(IRepository<>), repositoryType);
        services.AddScoped(typeof(IReadRepository<>), repositoryType);
        
        return services;
    }
}