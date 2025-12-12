# Script to update all docker-compose.yml files by removing the obsolete version line

$rootPath = Split-Path -Parent $MyInvocation.MyCommand.Path
$dockerComposeFiles = Get-ChildItem -Path $rootPath -Filter "docker-compose.yml" -Recurse -File

Write-Host "Found $($dockerComposeFiles.Count) docker-compose.yml files"

foreach ($file in $dockerComposeFiles) {
    Write-Host "Processing: $($file.FullName)"
    
    $content = Get-Content -Path $file.FullName -Raw
    
    # Remove the version line
    $updatedContent = $content -replace '(?m)^version:\s*".*"[\r\n]+', ''
    
    # Write back to file
    Set-Content -Path $file.FullName -Value $updatedContent -NoNewline
    
    Write-Host "Updated: $($file.FullName)" -ForegroundColor Green
}

Write-Host "`nAll files updated successfully!" -ForegroundColor Green
