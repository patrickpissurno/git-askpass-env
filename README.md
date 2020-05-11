# git-askpass-env
Replace `git-askpass.exe` with this one to make git get your credentials from environment variables.

Then make sure your `GIT_ASKPASS` environment variable points to the absolute path of `git-askpass-env.exe`.

Finally, you want to set the `GIT_PASSWORD` environment variable with your password.

Now you can go make some `git clone`s and `git pull`s and they will work as expected.
