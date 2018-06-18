$sourcePath = ($PSScriptRoot + "/publish")
$targetPath = ($PSScriptRoot + "/published.zip")

dotnet publish -o $sourcePath

if(Test-Path $targetPath)  {
    Remove-Item ($PSScriptRoot + "/published.zip")
}

Add-Type -Assembly System.IO.Compression.FileSystem
$compressionLevel = [System.IO.Compression.CompressionLevel]::Optimal
[System.IO.Compression.ZipFile]::CreateFromDirectory($sourcePath, $targetPath, $compressionLevel, $false)


Remove-Item -Recurse -Force $sourcePath