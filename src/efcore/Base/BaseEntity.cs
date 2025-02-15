// Copyright 2022 - 2023 Godwin peter .O (me@godwin.dev)
// 
// Licensed under the MIT License;
// you may not use this file except in compliance with the License.
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Axolotl.EFCore.Interfaces;

namespace Axolotl.EFCore.Base;

public abstract class BaseEntity<TKey> : CoreEntity, IHasKey<TKey> where TKey : notnull {
    [Key]
    [Column(Order=1)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(AutoGenerateField = false)]
    public TKey Id { get; set; } = default!;

    object IHasKey.Id {
        get => Id;
        set => Id = (TKey)value;
    }
}