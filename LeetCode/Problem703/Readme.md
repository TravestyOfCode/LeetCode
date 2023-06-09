﻿# [703. Kth Largest Element in a Stream](https://leetcode.com/problems/kth-largest-element-in-a-stream/)


Design a class to find the `kth` largest element in a stream. Note that it is the `kth` largest element in the sorted order, not the `kth` distinct element.

Implement `KthLargest` class:

* `KthLargest(int k, int[] nums)` Initializes the object with the integer k and the stream of integers nums.
* `int add(int val)` Appends the integer val to the stream and returns the element representing the kth largest element in the stream.

## Examples

```
Input
["KthLargest", "add", "add", "add", "add", "add"]
[[3, [4, 5, 8, 2]], [3], [5], [10], [9], [4]]
Output
[null, 4, 5, 5, 8, 8]

Explanation
KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]);
kthLargest.add(3);   // return 4
kthLargest.add(5);   // return 5
kthLargest.add(10);  // return 5
kthLargest.add(9);   // return 8
kthLargest.add(4);   // return 8
```

## Constraints
* 1 ≤ k ≤ 10^4^
* 0 ≤ nums.length ≤ 10^4^
* -10^4^ ≤ nums[i] ≤ 10^4^
* -10^4^ ≤ val ≤ 10^4^
* At most 10^4^ calls will be made to add.
* It is guaranteed that there will be at least `k` elements in the array when you search for the `kth` element.

## Thoughts

The `add` function adds a new number to the array (which was initialized with [4, 5, 8, 2]. The `null` value is the result from the initialization of the class, not any output. So with our first `add` call of 3 our sorted array would looke like `[2, 3, 4, 5, 8]` meaning the 3rd largest value would be `4`.

* `Add(5)` would cause sorted array to be `[2, 3, 4, 5, 5, 8]` so the 3rd largest would be the first `5`.
* `Add(10)` would cause sorted array to be `[2, 3, 4, 5, 5, 8, 10]` so 3rd largest would be the second `5`.
* `Add(9)` would cause sorted array to be `[2, 3, 4, 5, 5, 8, 9, 10]` so `8` is our value.
* `Add(4)` would cause sorted array to be `[2, 3, 4, 4, 5, 5, 8, 9, 10]` so we would still get `8`.

### First attempt
Simple idea to get working would be to sort the array after every add, then return `array[length - k]` adjusting for zero based if needed.

### Idea from user: skazantsev
We can build a `MinHeap` that contains only `k` largest elements. On `add`:
* compare a new element `x` with `min` to decide if we should `pop min` and `insert x`
* take into account a case when `heap_size` is less than `k`

First iteration I used an array that I would shift values to the right (and let them drop off) to insert a new value. I think I could increase the speed if I used a better method of bubbling up/down to limit the number of shifts. For small arrays it's not bad, but larger queue would be slow.

### Priority Queue
.NET 6.0 added a priority queue type that handles this. We keep track of how many items back we want to store so we can limit the size. We then add items to the queue, then check if we have too many items. If so, we remove the lowest value (called dequeue).