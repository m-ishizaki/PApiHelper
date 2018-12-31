# PApiHelper

# Usage

```cs
var apiClient = new PApiHelper.PApiClient
{
    ApiKey = "<取得したAPIKey>",
    BaseUrl = "http://localhost:1759/"
};
{// Item の取得
    var requestData = new PGetApiRequest();
    requestData.View.ColumnFilterHash.Add("Title", "<取得したいデータのタイトル>");
    var responseDataI = await apiClient.PostGetItemsAsync(<取得するデータのテーブルのID>, requestData);
}
{// 組織の取得
    var responseDataD = await apiClient.PostGetDeptsAsync(new PGetApiRequest());
}
{// グループの取得
    var responseDataG = await apiClient.PostGetGroupsAsync(new PGetApiRequest());
}
{// ユーザーの取得
    var responseDataU = await apiClient.PostGetUsersAsync(requestData);
}
{// Item の Create
    var responseData = await apiClient.PostCreateItemsAsync(<CreateするテーブルのID>, new PApiItem() { Title = "Create Title" });
}
{// Item の Update
    var responseData = await apiClient.PostUpdateItemsAsync(<Update するデータのID>, new PApiItem() { Title = "Update Title" });
}
{// Item のDelete
    var responseData = await apiClient.PostDeleteItemsAsync(<Delete するデータのID>, new PApiItem() { });
}
```
