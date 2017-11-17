# How to Contribute

Thanks for your interest in Noda Time. We appreciate all kinds of contributions, from submitting issues to improving documentation; from writing tests to implementing new code. All help is welcome!

## Basic Requirements

If you want to contribute to the codebase, you must have Visual
Studio 2017 installed - you can download the Community edition from
[here.](https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx) (The other editions will work fine as well.)

You're also going to need .NET Core SDK installed - you can download it from [here.](https://www.microsoft.com/net/download/)

Please make sure you have a [git client](https://git-scm.com/) installed. If you don't already have a Github account, [please create one.](https://github.com/signup/free)

After you're all set, you can [fork the project](https://help.github.com/articles/fork-a-repo). Then you'll be able to clone your fork, so you can edit the files locally on your machine:

`git clone https://github.com/YOUR-USERNAME/nodatime.git`

## How to start contributing?

We have an [`help-wanted`](https://github.com/nodatime/nodatime/labels/help%20wanted)
label on our issue tracker to indicate tasks which contributors can pick up.

If you've found something you'd like to work on, leave a comment in the issue
so everyone is aware and we don't waste efforts.

Additionally, feel free to open an issue if you find a bug or want to suggest a feature or enhancement.

## Making Changes

When you're ready to start working, create a new branch off the `master` branch:

```
git checkout master
git checkout -b SOME-BRANCH-NAME
```

Try to use a short, descriptive name for your branch, such as `add-unit-tests-foobar-struct`.

### Building

To build everything under Visual Studio, simply open the src\NodaTime-All.sln solution file and build normally. To build with just the .NET Core SDK, run

> dotnet restore src\NodaTime-All.sln
> 
> dotnet build src\NodaTime-All.sln

### Running Tests

The tests are currently console application projects until NUnit supports dotnet test properly. Simply run the following commands:

> cd src\NodaTime.Test
> dotnet run -f net451
> dotnet run -f netcoreapp1.0

### Submitting Changes

To publish your branch to your local fork, run this command from the Git Shell:

`git push origin -u MY-BRANCH-NAME`

Once your changes are ready to be reviewed, [open a pull request](https://help.github.com/articles/using-pull-requests) against it.

A few suggestions when opening a pull request:

 - if you're pull request fixes an issue, add a comment with the word "Fixes", "Resolves" or "Closes", followed by the issue's number:

>   Fixes #1145

 - add comments to the PR about things that are unclear or you would like
   suggestions on

Some things that will increase the chance that your pull request is accepted:

* Follow existing code conventions. Most of what we do follows [standard .NET
  conventions.](https://github.com/dotnet/corefx/blob/master/Documentation/coding-guidelines/coding-style.md)
* Include unit tests that would otherwise fail without your code, but pass with
  it.
* Update the documentation, the surrounding one, examples elsewhere, guides,
  whatever is affected by your contribution