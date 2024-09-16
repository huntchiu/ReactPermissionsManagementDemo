using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReactPermissionsManagementDemo.Server.Models;
public class Product
{
    public int Id { get; set; }
    // 名稱
    public string Name { get; set; } = string.Empty;

    // 價格
    [Column(TypeName = "decimal(8, 2)")]
    public decimal Price { get; set; }

}

