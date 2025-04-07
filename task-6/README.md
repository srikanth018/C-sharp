
# Task 6

## Delegates, Events, and Basic Event Handling

### Objective:
To implement a **console-based, event-driven application** in C# that uses **delegates and events** to handle logic based on a threshold being reached.



### Requirements:
- Define a **delegate** and use it to create an **event**.
- Trigger that event when a value (like a savings amount) meets or fails to meet a set condition.
- Create **separate handler methods** for each condition.
- Demonstrate how events allow you to **decouple the main logic** from the actions taken when the event occurs.



## Execution:

1. **Delegate Declaration**:  
   A delegate named `ReachedThreshold` is defined, which accepts an integer parameter representing the current savings.

2. **Event Declaration**:  
   Two events are created from the delegate:
   - `isReached`: triggered when the savings meet or exceed the threshold (100).
   - `isNotReached`: triggered when the savings are below the threshold.

3. **Initial Setup**:  
   The savings amount starts at Rs.95. The program asks the user to input an amount to add to the savings.

4. **Event Triggering**:  
   - After adding the new amount to the existing savings, the program checks:
     - If the total savings are **greater than or equal to 100**, the `isReached` event is fired.
     - Otherwise, the `isNotReached` event is fired.

5. **Event Handlers**:  
   Two handler methods are defined:
   - `GreaterThanThreshold`: displays a congratulatory message showing the total amount.
   - `LessThanThreshold`: displays a message indicating the goal hasn’t been met yet.

6. **Event Subscription**:  
   In the `Main` method, both handler methods are **subscribed to their respective events**. This means they will be automatically called when the events are triggered.

7. **Execution Flow**:  
   The user inputs an amount. Based on the result:
   - If the total savings reach or exceed 100, the user is congratulated.
   - Otherwise, the user is informed they haven't reached the goal yet.


## Sample Input & Output:

### Threshold Reached:

```
Enter the amount you want to add to your savings:
12
Congrats!!.. You have saved amount more than 100 and your current Amount is Rs.107
```

### ➤ Threshold Not Reached:

```
> dotnet run
Enter the amount you want to add to your savings:
3
Oops!!.. You haven't reached amount more than 100 and your current Amount is Rs.98
```