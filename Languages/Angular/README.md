# Angular

## Installation

### Programs

* [Visual Studio Code](https://code.visualstudio.com/)

* [Node](https://nodejs.org/es/)

* [Angular CLI](cli.angular.io)

```terminal
npm install -g @angular/cli
```

### Visual Studio Code Extensions

* [Activitus Bar](https://marketplace.visualstudio.com/items?itemName=Gruntfuggly.activitusbar)

* [Bracket Pair Colorizer 2](https://marketplace.visualstudio.com/items?itemName=CoenraadS.bracket-pair-colorizer-2)

Configuration:

```
"bracket-pair-colorizer-2.colors": [
    "#fafafa",
    "#9F51B6",
    "#F7C244",
    "#F07850",
    "#9CDD29",
    "#C497D4"
],
```

* [Icons](https://marketplace.visualstudio.com/items?itemName=PKief.material-icon-theme)

* [Angular Snippets](https://marketplace.visualstudio.com/items?itemName=Mikael.Angular-BeastCode)

* [Angular Language Service](https://marketplace.visualstudio.com/items?itemName=Angular.ng-template)

* [Angular Inline](https://marketplace.visualstudio.com/items?itemName=natewallace.angular2-inline)

* [Auto Close Tag](https://marketplace.visualstudio.com/items?itemName=formulahendry.auto-close-tag)

* [TypeScript importer](https://marketplace.visualstudio.com/items?itemName=pmneo.tsimporter)

## Commands

### Create new project

```terminal
ng new name
```

### Launch application

```terminal
ng serve
```

Parameters:

* -o : Opens a new window in the browser as soon as finished building.

### Build application

```terminal
npm install
```

Parameters:

* --save

### Create a new component

```terminal
ng g c route/name
```

Parameters:

* g : Generate
* c : Component
* --skip-tests: avoids creating the test file

### Create a new module

```terminal
ng g m route/name
```

Parameters:

* g: Generate
* m: Module

### Create a new service

```terminal
ng g s route/services/name
```

Parameters:

* --skip-tests: avoids creating the test file

### Create a new release

```terminal
ng build --configuration production
```

The folder that will matters to us is called "dist".

Where to upload this:

* Netlify
* Azure
* AWS

## Features

### Components

### Routes

### Directives

#### ngFor

#### ngIf

### Services

### Modules

### Templates

## Documentation
