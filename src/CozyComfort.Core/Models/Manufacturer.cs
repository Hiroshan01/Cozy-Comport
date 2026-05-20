namespace CozyComfort.Core.Models;

/// <summary>
/// නිර්මාතා (Manufacturer) - බ්ලැංකට් නිෂ්පාදනය කරන ආයතන
/// </summary>
public class Manufacturer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public string ContactPhone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    
    // නිර්මාණ ක්ষමතා (උවස/සතිනට)
    public int ProductionCapacity { get; set; }
    
    // ප්‍රධාන ස්ටොක් පිරිසර
    public int CurrentStock { get; set; }
    
    // නිෂ්පාදන ගබඩා (දින ගණනින්)
    public int LeadTimeDays { get; set; }
    
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    
    // සම්බන්ධතා
    public ICollection<Blanket> Blankets { get; set; } = new List<Blanket>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
