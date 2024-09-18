#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Quercus.Models;
#pragma warning restore IDE0130 // Namespace does not match folder structure

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
