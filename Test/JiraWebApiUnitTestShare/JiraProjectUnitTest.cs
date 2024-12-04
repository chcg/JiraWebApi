﻿namespace JiraWebApiUnitTest;

[TestClass]
public class JiraProjectUnitTest : JiraBaseUnitTest
{
    [TestMethod]
    public async Task TestMethodGetProjectsAsync()
    {
        using var jira = new Jira(host, apikey);

        var res = await jira.GetProjectsAsync();

        var projects = res?.ToList();
        Assert.IsNotNull(projects);

        var project = projects.FirstOrDefault(p => p.Key == testProject);
        Assert.IsNotNull(project);
        Assert.AreEqual("https://jira.elektrobit.com/rest/api/2/project/25411", project.Self, nameof(project.Self));
        Assert.AreEqual("25411", project.Id, nameof(project.Id));
        Assert.AreEqual("Navigation Suite", project.Name, nameof(project.Name));
        Assert.AreEqual("NAVSUITE", project.Key, nameof(project.Key));
        Assert.AreEqual(null, project.Description, nameof(project.Description));
        Assert.AreEqual(null, project.Url?.ToString(), nameof(project.Url));
        Assert.AreEqual(null, project.Email, nameof(project.Email));
        Assert.AreEqual(null, project.AssigneeType, nameof(project.AssigneeType));
    }
}
