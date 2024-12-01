## BiDictionary

### Short Description
Create bi-directional dictionary class.

### Requirements
1. Code style.
2. It can look like:
   ```cs
   BiDictionary<T1, T2>: IDictionary<T1, T2>
   {
     public IReadOnlyDictionary<T2, T1> Inverse { get; }
   }
   ```
3. Implement interface members.
4. Add unit tests.
