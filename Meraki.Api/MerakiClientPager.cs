﻿namespace Meraki.Api;

/// <summary>
/// This file contains paging logic
/// </summary>
public partial class MerakiClient
{
	public async Task<List<T>> GetAllAsync<T>(
		Func<int, string?, CancellationToken, Task<List<T>>> pageFactoryAsync,
		int perPage,
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		var finished = false;
		string? startingAfter = null;
		while (!finished)
		{
			var pageResponse = await
				pageFactoryAsync(perPage, startingAfter, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(pageResponse);

			// Check the Link response header
			if (LastResponseHeaders is not null && LastResponseHeaders.TryGetValues("Link", out var linkHeaders))
			{
				// We found a Link header
				var linkHeader = linkHeaders.FirstOrDefault();
				if (linkHeader != null)
				{
					var links = linkHeader.Split(',');
					var nextLink = links.SingleOrDefault(link => link.Contains("rel=next"));
					if (nextLink != null)
					{
						var nextLinkComponents = nextLink.Split(';');
						if (nextLinkComponents.Length == 2)
						{
							// Get the url component and remove the < > wrapper
							var nextLinkUrl = nextLinkComponents[0].Trim().TrimStart('<').TrimEnd('>');
							var myUri = new Uri(nextLinkUrl);
							var nvCol = HttpUtility.ParseQueryString(myUri.Query);
							startingAfter = nvCol.Get("startingAfter");
							continue;
						}
					}
				}
			}

			// There was no Link header so we're finished
			finished = true;
		}
		return allEntries;
	}

	public async Task<List<T>> GetAllAsync<T>(
		Func<string?, CancellationToken, Task<List<T>>> pageFactoryAsync,
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		var finished = false;
		string? startingAfter = null;
		while (!finished)
		{
			var pageResponse = await
				pageFactoryAsync(startingAfter, cancellationToken).ConfigureAwait(false);

			allEntries.AddRange(pageResponse);

			// Check the Link response header
			if (LastResponseHeaders is not null && LastResponseHeaders.TryGetValues("Link", out var linkHeaders))
			{
				// We found a Link header
				var linkHeader = linkHeaders.FirstOrDefault();
				if (linkHeader != null)
				{
					var links = linkHeader.Split(',');
					var nextLink = links.SingleOrDefault(link => link.Contains("rel=next"));
					if (nextLink != null)
					{
						var nextLinkComponents = nextLink.Split(';');
						if (nextLinkComponents.Length == 2)
						{
							// Get the url component and remove the < > wrapper
							var nextLinkUrl = nextLinkComponents[0].Trim().TrimStart('<').TrimEnd('>');
							var myUri = new Uri(nextLinkUrl);
							var nvCol = HttpUtility.ParseQueryString(myUri.Query);
							startingAfter = nvCol.Get("startingAfter");
							continue;
						}
					}
				}
			}

			// There was no Link header so we're finished
			finished = true;
		}
		return allEntries;
	}

	public static async Task<List<T>> GetAllAsync<T>(
		Func<string?, CancellationToken, Task<ApiResponse<List<T>>>> pageFactoryAsync,
		CancellationToken cancellationToken)
	{
		var allEntries = new List<T>();
		var finished = false;
		string? startingAfter = null;
		while (!finished)
		{
			var pageResponse = await
				pageFactoryAsync(startingAfter, cancellationToken).ConfigureAwait(false);

			// Refit traps exceptions into Error when using ApiResponse
			if (pageResponse.Error is not null)
			{
				throw pageResponse.Error;
			}

			allEntries.AddRange(pageResponse.Content);

			// Check the Link response header
			if (pageResponse.Headers is not null && pageResponse.Headers.TryGetValues("Link", out var linkHeaders))
			{
				// We found a Link header
				var linkHeader = linkHeaders.FirstOrDefault();
				if (linkHeader != null)
				{
					var links = linkHeader.Split(',');
					var nextLink = links.SingleOrDefault(link => link.Contains("rel=next"));
					if (nextLink != null)
					{
						var nextLinkComponents = nextLink.Split(';');
						if (nextLinkComponents.Length == 2)
						{
							// Get the url component and remove the < > wrapper
							var nextLinkUrl = nextLinkComponents[0].Trim().TrimStart('<').TrimEnd('>');
							var myUri = new Uri(nextLinkUrl);
							var nvCol = HttpUtility.ParseQueryString(myUri.Query);
							startingAfter = nvCol.Get("startingAfter");
							continue;
						}
					}
				}
			}

			// There was no Link header so we're finished
			finished = true;
		}
		return allEntries;
	}
}
