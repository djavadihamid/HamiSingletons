# HamiSingletons

HamiSingletons are set of scripts to make singleton process an easy to do action.
Package should be used in Unity but the concepts in it can bee used in any other platform.

## Installation
Use this repository as submodele of your project git repository
```gitexclude
via https:
git submodule add https://github.com/djavadihamid/HamiSingletons.git PATH_TO_CLONE

or via SSH:
git submodule add git@github.com:djavadihamid/HamiSingletons.git PATH_TO_CLONE
```

or if you want to work on this repository just clone the repository and voila.
```gitexclude
Via https:
git clone https://github.com/djavadihamid/HamiSingletons.git

Or via SSH:
git clone git@github.com:djavadihamid/HamiSingletons.git
```
## Usage

```c#
public class YourClassName : SimpleSingleton<YourClassName>{

}
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
s