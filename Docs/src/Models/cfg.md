# CFG

## Light

### Type

doesn't seem to work out of the box

0 - sun?

1 - ??

2 - Spot

3 - ??

### Graph

```xml
<GraphDuration>3.000000</GraphDuration>
<ColorGraph>
    <i>
        <t>0.000000</t>
        <c.r>0.000000</c.r>
        <c.g>0.000000</c.g>
        <c.b>1.000000</c.b>
        <c.a>1.000000</c.a>
    </i>
    <i>
        <t>0.500000</t>
        <c.r>1.000000</c.r>
        <c.g>0.000000</c.g>
        <c.b>0.000000</c.b>
        <c.a>1.000000</c.a>
    </i>
    <i>
        <t>0.750000</t>
        <c.r>0.000000</c.r>
        <c.g>1.000000</c.g>
        <c.b>0.000000</c.b>
        <c.a>1.000000</c.a>
    </i>
</ColorGraph>
```

t - percentage of the total GraphDuration

rgb - red green blue

a - alpha

<div class="tip">to make it smooth you have to apply the same color to t=0 and t=1</div>