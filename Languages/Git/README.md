# Git

## Installation

* [Git](https://git-scm.com)

## Commands

### Configuration

* Version

```terminal
git --version
```

* Help
```terminal
git help
```

* Set user configuration

```terminal
git config --global user.email "Email" 
git config --global user.name "Name"
```

* List global configuration items

```terminal
git config --global -l
```

### Initialize project

```terminal
git init
```

### Clone

```terminal
git clone <url>
```

### See status of repository

```terminal
git status
```

Parameters:

* -s: Simplified information
* -b: Indicates actual branch

### Add

```terminal
git add
```

Parameters:

* .: adds every file to the stage
* folder/: adds every file of a folder

### Commit

```terminal
git commit
```

Parameters:

* -m "Message": allows to create a new commit with an specified message

### Checkout

```terminal
git checkout --
```

### Diff

List changes of the files

```terminal
git diff
```

Parameters:

* --staged: List changes of the files in the stage.

Differences between two branches

```terminal
git diff branchA branchB
```

### Fetch

```terminal
git fetch <origin>
```

### Pull

```terminal
git pull <remote> <branch>
```

### Push

```terminal
git push <remote> <branch>
```

Parameters:

* -f: force push
* -u: push and set as default branch
* --tags: Uploads every new tag created

### Branches

List all branches

```terminal
git branch
```

Parameters:

* <Name>: Creates a new branch
* -a: List local and remote branches
* checkout <Name>: Change to a branch
* checkout -b <Name>: Creates a new branch and changes to it
* checkout -b <Name> <remote>/<Name>: Move to a remote branch and creates it localy
* -d <Name>: Deletes a branch

### Remote

```terminal
git remote
```

Parameters:

* add <origin><url>: adds new remote
* -v: shows every remote created.

### Log

List every commit of the repository

```terminal
git log
```

Parameters:

* --oneline: display simplified logs
* --oneline --decorate --all --graph: personalized command

### Reflog

List all logs

```terminal
git reflog
```

### Tags

List all tags

```terminal
git tag
```

Parameters:

* Name: creates a new tag
* -a v1.0.0 -m "Version 1.0.0": creates a versioned tag
* -a v1.0.0 id_commit -m "M": creates a tag for a determinated commit
* -d Name: deletes tag 
* show Name: displays all info about the tag 

### Stash

```terminal
git stash
```

Parameters:

* save: Saves stash
* save "Message": Saves stash with message
* list --stat: List available stash
* apply stash@{i}: Loads a saved stash
* pop: Gets stash and deletes it
* drop stash@{i}: Deletes a stash
* clear: Deletes all stash

### Merge

<Pending>

### Rebase

<Pending>

## Documentation

