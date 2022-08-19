# JUtil

## JUtilとは

Unity用のオレオレライブラリ

## 使い方

### DataWriter

DataWriterは様々な型をbytes配列に変換できるクラスです。

``` c#
DataWriter writer = new DataWriter();
writer.Put(6);
Console.WriteLine(string.Join(',', writer.GetData()));
```

``` 結果
6,0,0,0
```

### DataReader

DataReaderはbytes配列を様々な型に変換できるクラスです。

``` c#
byte[] value = new byte[]{
    6,
    0,
    0,
    0,
};

DataReader reader = new DataReader();
Console.WriteLine(reader.GetInt());
```

``` 結果
6
```
