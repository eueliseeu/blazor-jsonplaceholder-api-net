namespace BlazorUsersJsonPlaceHolderApi.Models;

public sealed class User
{
  public int Id { get; set; }

  public string Name { get; set; } = string.Empty;

  public Address Address { get; set; } = new();

  public Company Company { get; set; } = new();
}

public sealed class Address
{
  public string City { get; set; } = string.Empty;
}

public sealed class Company
{
  public string Name { get; set; } = string.Empty;
}
