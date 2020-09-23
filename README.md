## JavaScript Handler NuGet Package

<span id='contents'>

1. [Overview](#1)
2. [Namespace and Instantiation](#2)
3. [Configuration](#3)
4. [Methods](#4)
5. [Example](#5)

</span>

<a name='1' style="padding-top: 50px">

### Overview

- The JavaScript Handler Package is used to easily inject javascript from .Net codebehind page
- Minimum Target Framework: 4.6.1

<a name='2' style="padding-top: 50px">

### Namespace and Instantiation

- The namespace for the Javascript class is Javascript_Handler and will need to be referenced in your project after installing the NuGet package.
    ```C#
    using Javascript_Handler;
    ```
- The **Javascript** class is instatiated using the default contstructor passing the current ```Page``` (```System.Web.UI.Page```) instance.
    ```C#
    var scripthandler = new Javascript(Page page);
    ```

<a name='3' style="padding-top: 50px">

### Configuration

- There is no configuration needed to use the Javascript object after instantiation.

<a name='4' style="padding-top: 50px">

### Methods

#### alert()
- This will add an alert to the header section of your page
    ``` C#
    public void alert(string message = "")
    ```

#### addScript()
- This will add an whatever script is passed to the method to the header section of your page
    ``` C#
    public void addScript(string script)
    ```

<a name='5' style="padding-top: 50px">

### Example

```C#
using Javascript_Handler;

public void addMyScript(string script)
{
    Javascript handler = new Javascript(this.Page);
    handler.addScript(script);
}
 
```
