using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
         var priorityQueue = new PriorityQueue();
          priorityQueue.Enqueue("Low", 2);
          priorityQueue.Enqueue("High", 10);
          priorityQueue.Enqueue("Medium", 5);

    var result = priorityQueue.Dequeue();
    Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
       var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("JobA", 5);
        priorityQueue.Enqueue("JobB", 10);
        priorityQueue.Enqueue("JobC", 5);
        priorityQueue.Enqueue("JobD", 10);

    var result = priorityQueue.Dequeue();
    Assert.AreEqual("JobB", result);
    }

    // Add more test cases as needed below.
}