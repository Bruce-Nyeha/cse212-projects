using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with varied priority values: Low (2), High (10), Medium (5). Dequeue once.
    // Expected Result: "High" is returned because 10 is the maximum priority value in the collection.
    // Defect(s) Found: The original code used a loop constraint of "_queue.Count - 1" which blinded it from checking the very last element in the list. It also lacked the "_queue.RemoveAt()" function to delete the item after returning it.

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
    // Scenario: Enqueue items with identical high priorities to validate the tie-breaker rule: JobA (5), JobB (10), JobC (5), JobD (10). Dequeue once.
    // Expected Result: "JobB" is returned because it is closest to the front of the queue among the tied elements (FIFO rule).
    // Defect(s) Found: The original code used a ">=" operator in the priority comparison check, which incorrectly allowed duplicate priorities further back in line to overwrite and skip ahead of earlier entries.
 
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