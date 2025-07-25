---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Storage.dll-Help.xml
Module Name: Az.Storage
ms.assetid: FA98E64B-D589-4653-9ACC-86573FAF4550
online version: https://learn.microsoft.com/powershell/module/az.storage/set-azstoragefilecontent
schema: 2.0.0
---

# Set-AzStorageFileContent

## SYNOPSIS
Uploads the contents of a file.

## SYNTAX

### ShareName (Default)
```
Set-AzStorageFileContent [-ShareName] <String> [-Source] <String> [[-Path] <String>] [-FileMode <String>]
 [-Owner <String>] [-Group <String>] [-PassThru] [-Force] [-AsJob] [-DisAllowTrailingDot]
 [-Context <IStorageContext>] [-ServerTimeoutPerRequest <Int32>] [-ClientTimeoutPerRequest <Int32>]
 [-DefaultProfile <IAzureContextContainer>] [-ConcurrentTaskCount <Int32>]
 [-WhatIf] [-Confirm] [-PreserveSMBAttribute] [<CommonParameters>]
```

### Share
```
Set-AzStorageFileContent [-ShareClient] <ShareClient> [-Source] <String> [[-Path] <String>]
 [-FileMode <String>] [-Owner <String>] [-Group <String>] [-PassThru] [-Force] [-AsJob]
 [-Context <IStorageContext>] [-ServerTimeoutPerRequest <Int32>] [-ClientTimeoutPerRequest <Int32>]
 [-DefaultProfile <IAzureContextContainer>] [-ConcurrentTaskCount <Int32>]
 [-WhatIf] [-Confirm] [-PreserveSMBAttribute] [<CommonParameters>]
```

### Directory
```
Set-AzStorageFileContent [-ShareDirectoryClient] <ShareDirectoryClient> [-Source] <String> [[-Path] <String>]
 [-FileMode <String>] [-Owner <String>] [-Group <String>] [-PassThru] [-Force] [-AsJob]
 [-Context <IStorageContext>] [-ServerTimeoutPerRequest <Int32>] [-ClientTimeoutPerRequest <Int32>]
 [-DefaultProfile <IAzureContextContainer>] [-ConcurrentTaskCount <Int32>]
 [-WhatIf] [-Confirm] [-PreserveSMBAttribute] [<CommonParameters>]
```

## DESCRIPTION
The **Set-AzStorageFileContent** cmdlet uploads the contents of a file to a file on a specified share.

## EXAMPLES

### Example 1: Upload a file in the current folder
```powershell
Set-AzStorageFileContent -ShareName "ContosoShare06" -Source "DataFile37" -Path "ContosoWorkingFolder/CurrentDataFile"
```

This command uploads a file that is named DataFile37 in the current folder as a file that is named CurrentDataFile in the folder named ContosoWorkingFolder.

### Example 2: Upload all the files in the current folder
```powershell
$CurrentFolder = (Get-Item .).FullName
$Container = Get-AzStorageShare -Name "ContosoShare06"
Get-ChildItem -Recurse | Where-Object { $_.GetType().Name -eq "FileInfo"} | ForEach-Object {
    $path=$_.FullName.Substring($Currentfolder.Length+1).Replace("\","/")
    Set-AzStorageFileContent -ShareClient $Container -Source $_.FullName -Path $path -Force
}
```

This example uses several common Windows PowerShell cmdlets and the current cmdlet to upload all files from the current folder to the root folder of container ContosoShare06.
The first command gets the name of the current folder and stores it in the $CurrentFolder variable.
The second command uses the **Get-AzStorageShare** cmdlet to get the file share named ContosoShare06, and then stores it in the $Container variable.
The final command gets the contents of the current folder and passes each one to the Where-Object cmdlet by using the pipeline operator.
That cmdlet filters out objects that are not files, and then passes the files to the ForEach-Object cmdlet.
That cmdlet runs a script block for each file that creates the appropriate path for it and then uses the current cmdlet to upload the file.
The result has the same name and same relative position with regard to the other files that this example uploads.
For more information about script blocks, type `Get-Help about_Script_Blocks`.

### Example 3: Upload a local file to an Azure file, and preserve the local File SMB properties (File Attributes, File Creation Time, File Last Write Time) in the Azure file.
```powershell
Set-AzStorageFileContent -Source $localFilePath -ShareName sample -Path "dir1/file1" -PreserveSMBAttribute
```

This example uploads a local file to an Azure file, and preserves the local File SMB properties (File Attributes, File Creation Time, File Last Write Time) in the Azure file.

### Example 4:  Upload a file with FileMode, Owner and Group to a NFS file share
```powershell
Set-AzStorageFileContent -ShareName "contososhare06" -Source "DataFile37" -Path "ContosoWorkingFolder/CurrentDataFile" -FileMode rw-r--rwt -Owner 1 -Group 1
```

This command uploads a local file to an Azure file with FileMode rwxrwSrwx, Owner 1 and Group 1. 
FileMode, Owner, Group only works on NFS file share. 

## PARAMETERS

### -AsJob
Run cmdlet in the background.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientTimeoutPerRequest
Specifies the client-side time-out interval, in seconds, for one service request.
If the previous call fails in the specified interval, this cmdlet retries the request.
If this cmdlet does not receive a successful response before the interval elapses, this cmdlet returns an error.

```yaml
Type: System.Nullable`1[System.Int32]
Parameter Sets: (All)
Aliases: ClientTimeoutPerRequestInSeconds

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConcurrentTaskCount
Specifies the maximum concurrent network calls.
You can use this parameter to limit the concurrency to throttle local CPU and bandwidth usage by specifying the maximum number of concurrent network calls.
The specified value is an absolute count and is not multiplied by the core count.
This parameter can help reduce network connection problems in low bandwidth environments, such as 100 kilobits per second.
The default value is 10.

```yaml
Type: System.Nullable`1[System.Int32]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Context
Specifies an Azure storage context.
To obtain a storage context, use the [New-AzStorageContext](./New-AzStorageContext.md) cmdlet.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.IStorageContext
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName, ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisAllowTrailingDot
Disallow trailing dot (.) to suffix directory and file names.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ShareName
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileMode
Only applicable to NFS Files. The mode permissions to be set on the file. Symbolic (rwxrw-rw-) is supported.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Force
Indicates that this cmdlet overwrites an existing Azure storage file.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Group
Only applicable to NFS Files. The owner group identifier (GID) to be set on the file. The default value is 0 (root group).

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Owner
Only applicable to NFS Files. The owner user identifier (UID) to be set on the file. The default value is 0 (root).

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Indicates that this cmdlet returns the **AzureStorageFile** object that it creates or uploads.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Path
Specifies the path of a file or folder.
This cmdlet uploads contents to the file that this parameter specifies, or to a file in the folder that this parameter specifies.
If you specify a folder, this cmdlet creates a file that has the same name as the source file.
If you specify a path of a file that does not exist, this cmdlet creates that file and saves the contents to that file.
If you specify a file that already exists, and you specify the _Force_ parameter, this cmdlet overwrites the contents of the file.
If you specify a file that already exists and you do not specify _Force_, this cmdlet makes no change, and returns an error.
If you specify a path of a folder that does not exist, this cmdlet makes no change, and returns an error.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PreserveSMBAttribute
Keep the source File SMB properties (File Attributes, File Creation Time, File Last Write Time) in destination File. This parameter is only available on Windows.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServerTimeoutPerRequest
Specifies the length of the time-out period for the server part of a request.

```yaml
Type: System.Nullable`1[System.Int32]
Parameter Sets: (All)
Aliases: ServerTimeoutPerRequestInSeconds

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ShareClient
ShareClient object indicated the share where the file would be uploaded to.

```yaml
Type: Azure.Storage.Files.Shares.ShareClient
Parameter Sets: Share
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName, ByValue)
Accept wildcard characters: False
```

### -ShareDirectoryClient
ShareDirectoryClient object indicated the directory where the file would be uploaded.

```yaml
Type: Azure.Storage.Files.Shares.ShareDirectoryClient
Parameter Sets: Directory
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName, ByValue)
Accept wildcard characters: False
```

### -ShareName
Specifies the name of the file share.
This cmdlet uploads to a file in the file share this parameter specifies.

```yaml
Type: System.String
Parameter Sets: ShareName
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Source
Specifies the source file that this cmdlet uploads.
If you specify a file that does not exist, this cmdlet returns an error.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: FullName

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Azure.Storage.Files.Shares.ShareClient

### Azure.Storage.Files.Shares.ShareDirectoryClient

### System.String

### Microsoft.Azure.Commands.Common.Authentication.Abstractions.IStorageContext

## OUTPUTS

### Microsoft.WindowsAzure.Commands.Common.Storage.ResourceModel.AzureStorageFile

## NOTES

## RELATED LINKS

[Remove-AzStorageDirectory](./Remove-AzStorageDirectory.md)

[New-AzStorageDirectory](./New-AzStorageDirectory.md)

[Get-AzStorageFileContent](./Get-AzStorageFileContent.md)
