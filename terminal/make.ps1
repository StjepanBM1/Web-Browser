if ($($args[0]) -eq "mono")
{
    Write-Output "Mono"
    make mono # Install Makefile support for windows
}

else
{
    Write-Output ".NET 5"
    make # Install Makefile support for windows
}