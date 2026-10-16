using System.Net.Http.Json;
using BlazorUsersJsonPlaceHolderApi.Models;

namespace BlazorUsersJsonPlaceHolderApi.Services;

public sealed class UserService(HttpClient httpClient)
{
  private const string UsersEndpoint = "https://jsonplaceholder.typicode.com/users";

  public async Task<IReadOnlyList<User>> GetUsersAsync(CancellationToken cancellationToken = default)
  {
    var users = await httpClient.GetFromJsonAsync<List<User>>(UsersEndpoint, cancellationToken);

    return users ?? [];
  }
}
