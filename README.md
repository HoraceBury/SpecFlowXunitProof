# SpecFlowXunitProof
Demo/PoC of using xUnit with SpecFlow.

## About
This is a simple demo/PoC showing how to use xUnit, SpecFlow, Selenium, headless Chrome and PhantomJS (before it gets removed).

## SpecFlow
### Visual Studio Plugin
This solution needs the Visual Studio SpecFlow plugin:
https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowforVisualStudio2015

### Setting up SpecFlow feature files for code-behind-less use
See this article for setting up your feature files to run under xUnit without a code-behind file:
http://gasparnagy.com/2017/04/specflow-without-code-behind-files/

## xUnit
See here for how to structure xUnit unit tests:
http://blog.benhall.me.uk/2008/01/introduction-to-xunit/

## Headless Browser
### PhantomJS
As of mid-2017 PhantomJS has been end-of-life'd because Google's Chrome officially supports headless mode.

### Headless Chrome
#### Intro
See here for how to setup Chrome in headless mode:
http://executeautomation.com/blog/running-chrome-in-headless-mode-with-selenium-c/

#### Getting it working
Sometimes Chrome will not work under ChromeDriver, so check here for how to fix that:
https://stackoverflow.com/a/49361960/71376
