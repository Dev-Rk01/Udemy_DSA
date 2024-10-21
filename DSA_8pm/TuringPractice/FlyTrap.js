### **Problem Statement:**

There are several frogs on a line, each with an integer coordinate and a specific tongue size. Specifically:
- The **i-th frog** is located at coordinate \( X[i] \) with a tongue size \( S[i] \).
- Additionally, there are several flies positioned on integer coordinates, where the **j-th fly** is located at coordinate \( Y[j] \).

A frog \( i \) can eat a fly \( j \) if, and only if:
\[
|X[i] - Y[j]| \leq S[i]
\]
This means the frog can eat the fly if the **distance** between the frog and the fly is less than or equal to the frog's tongue size.

---

### **Your Task:**
For each frog, determine how many flies it can eat.

---

### **Input Format:**
- **X**: List of integers representing the positions of the frogs.
- **S**: List of integers representing the tongue sizes of the frogs.
- **Y**: List of integers representing the positions of the flies.

---

### **Output Format:**
- Return a list of integers where the **i-th element** represents the number of flies the **i-th frog** can eat.

---

### **Example 1:**
**Input:**
```
X = [1, 4, 5]
S = [2, 3, 5]
Y = [2, 3, 5]
```
**Output:**
```
[2, 3, 3]
```

---

### **Example 2:**
**Input:**
```
X = [3]
S = [5]
Y = [7, 1, 2]
```
**Output:**
```
[3]
```

function countFliesEaten(x , s, y) {
    let result = [];

    for(let i = 0; i < x.length, i++) {
        let frogPosition = x[i];
        let tongueSize = s[i];
        let fliesEaten = 0;

        for(let j = 0; j < y.length; j++) {
            let fliesPosition = y[j]
            if(Math.abs(frogPosition - fliesPosition) <= tongueSize) fliesEaten++;
        }
        result.push(fliesEaten);
    }
    return result;
}




function countFliesEaten(x,y,s) {
    let result = [];
    for(let i=0;i<x.length;i++) {
        let frogPosition = x[i];
        let toungeSize = s[i];
        let fliesEaten = 0;
        for(let j=0;j<y.length;j++) {
            let fliesPosition = y[j];
            if(Math.abs(frogPosition-fliesPosition) <= toungeSize) fliesEaten++;
        }
        result.push(fliesEaten);
    }
    return result
}

function countFliesEaten(x,y,s) {
    let result = [];
    for(let i=0;i<x.length;i++) {
        let frogPosition = x[i];
        let tongueSize = s[i];
        let fliesEaten = 0;
        for(let j=0;j<y.length;j++) {
            let fliesPosition = y[j];
            if(frogPosition + tongueSize >= fliesPosition) fliesEaten++;
        }
        result.push(fliesEaten);
    }
    
    return result;
}