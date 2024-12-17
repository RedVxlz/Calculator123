# Calculator

by ปลวัชร สุทธมา,
673450473-2,
Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
private void button1_Click(object sender, EventArgs e)
{
    // ข้อความตัวอักษร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    // int ทำให้เราสามารถทำการ + - * / ได้
    int iResult = iNum1 + iNum2;
    // ที่ตัวแปรชื่อ result
    // มีคุณสมบัติชื่อ Text
    result.Text = iResult.ToString();
}
```

### รับข้อมูล

ตัวอย่าง

```
string inputNum1 = textBox1.Text;
string inputNum2 = textBox2.Text;
```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```
int iNum1 = Int32.Parse(inputNum1);
int iNum2 = Int32.Parse(inputNum2);
```

### คำนวนผลลัพท์

ตัวอย่าง

```
int AddResult = iNum1 + iNum2;
```

### แสดงผล

ตัวอย่าง

```
ResultBox.Text = AddResult.ToString();
```

## ปุ่มลบ
```
private void buttonSub_Click(object sender, EventArgs e)
{
    string inputNum1 = textBox1.Text;
    string inputNum2 = textBox2.Text;

    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);

    int AddResult = iNum1 - iNum2;
    ResultBox.Text = AddResult.ToString();
}

```
## ปุ่มคูณ
```
private void buttonDivide_Click(object sender, EventArgs e)
{
    string inputNum1 = textBox1.Text;
    string inputNum2 = textBox2.Text;

    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);

    int AddResult = iNum1 * iNum2;
    ResultBox.Text = AddResult.ToString();
}

```
## ปุ่มหาร
```
private void buttonMultiply_Click(object sender, EventArgs e)
{
    string inputNum1 = textBox1.Text;
    string inputNum2 = textBox2.Text;

    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);

    int AddResult = iNum1 / iNum2;
    ResultBox.Text = AddResult.ToString();
}

```
## ปุ่มลบข้อมูล
```
private void buttonClear_Click(object sender, EventArgs e)
{
    ResultBox.Clear();
}

```
