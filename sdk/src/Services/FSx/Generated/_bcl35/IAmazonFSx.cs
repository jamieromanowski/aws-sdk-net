/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FSx.Model;

namespace Amazon.FSx
{
    /// <summary>
    /// Interface for accessing FSx
    ///
    /// Amazon FSx is a fully managed service that makes it easy for storage and application
    /// administrators to launch and use shared file storage.
    /// </summary>
    public partial interface IAmazonFSx : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFSxPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateFileSystemAliases


        /// <summary>
        /// Use this action to associate one or more Domain Name Server (DNS) aliases with an
        /// existing Amazon FSx for Windows File Server file system. A file system can have a
        /// maximum of 50 DNS aliases associated with it at any one time. If you try to associate
        /// a DNS alias that is already associated with the file system, FSx takes no action on
        /// that alias in the request. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">Working
        /// with DNS Aliases</a> and <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/walkthrough05-file-system-custom-CNAME.html">Walkthrough
        /// 5: Using DNS aliases to access your file system</a>, including additional steps you
        /// must take to be able to access your file system using a DNS alias.
        /// 
        ///  
        /// <para>
        /// The system response shows the DNS aliases that Amazon FSx is attempting to associate
        /// with the file system. Use the API operation to monitor the status of the aliases Amazon
        /// FSx is associating with the file system.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFileSystemAliases service method.</param>
        /// 
        /// <returns>The response from the AssociateFileSystemAliases service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/AssociateFileSystemAliases">REST API Reference for AssociateFileSystemAliases Operation</seealso>
        AssociateFileSystemAliasesResponse AssociateFileSystemAliases(AssociateFileSystemAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateFileSystemAliases operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateFileSystemAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/AssociateFileSystemAliases">REST API Reference for AssociateFileSystemAliases Operation</seealso>
        IAsyncResult BeginAssociateFileSystemAliases(AssociateFileSystemAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateFileSystemAliases.</param>
        /// 
        /// <returns>Returns a  AssociateFileSystemAliasesResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/AssociateFileSystemAliases">REST API Reference for AssociateFileSystemAliases Operation</seealso>
        AssociateFileSystemAliasesResponse EndAssociateFileSystemAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelDataRepositoryTask


        /// <summary>
        /// Cancels an existing Amazon FSx for Lustre data repository task if that task is in
        /// either the <code>PENDING</code> or <code>EXECUTING</code> state. When you cancel a
        /// task, Amazon FSx does the following.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Any files that FSx has already exported are not reverted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FSx continues to export any files that are "in-flight" when the cancel operation is
        /// received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FSx does not export any files that have not yet been exported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDataRepositoryTask service method.</param>
        /// 
        /// <returns>The response from the CancelDataRepositoryTask service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskEndedException">
        /// The data repository task could not be canceled because the task has already ended.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskNotFoundException">
        /// The data repository task or tasks you specified could not be found.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CancelDataRepositoryTask">REST API Reference for CancelDataRepositoryTask Operation</seealso>
        CancelDataRepositoryTaskResponse CancelDataRepositoryTask(CancelDataRepositoryTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelDataRepositoryTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDataRepositoryTask operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDataRepositoryTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CancelDataRepositoryTask">REST API Reference for CancelDataRepositoryTask Operation</seealso>
        IAsyncResult BeginCancelDataRepositoryTask(CancelDataRepositoryTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDataRepositoryTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDataRepositoryTask.</param>
        /// 
        /// <returns>Returns a  CancelDataRepositoryTaskResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CancelDataRepositoryTask">REST API Reference for CancelDataRepositoryTask Operation</seealso>
        CancelDataRepositoryTaskResponse EndCancelDataRepositoryTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CopyBackup


        /// <summary>
        /// Copies an existing backup within the same Amazon Web Services account to another Amazon
        /// Web Services Region (cross-Region copy) or within the same Amazon Web Services Region
        /// (in-Region copy). You can have up to five backup copy requests in progress to a single
        /// destination Region per account.
        /// 
        ///  
        /// <para>
        /// You can use cross-Region backup copies for cross-Region disaster recovery. You can
        /// periodically take backups and copy them to another Region so that in the event of
        /// a disaster in the primary Region, you can restore from backup and recover availability
        /// quickly in the other Region. You can make cross-Region copies only within your Amazon
        /// Web Services partition. A partition is a grouping of Regions. Amazon Web Services
        /// currently has three partitions: <code>aws</code> (Standard Regions), <code>aws-cn</code>
        /// (China Regions), and <code>aws-us-gov</code> (Amazon Web Services GovCloud [US] Regions).
        /// </para>
        ///  
        /// <para>
        /// You can also use backup copies to clone your file dataset to another Region or within
        /// the same Region.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>SourceRegion</code> parameter to specify the Amazon Web Services
        /// Region from which the backup will be copied. For example, if you make the call from
        /// the <code>us-west-1</code> Region and want to copy a backup from the <code>us-east-2</code>
        /// Region, you specify <code>us-east-2</code> in the <code>SourceRegion</code> parameter
        /// to make a cross-Region copy. If you don't specify a Region, the backup copy is created
        /// in the same Region where the request is sent from (in-Region copy).
        /// </para>
        ///  
        /// <para>
        /// For more information about creating backup copies, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-backups.html#copy-backups">
        /// Copying backups</a> in the <i>Amazon FSx for Windows User Guide</i>, <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-backups-fsx.html#copy-backups">Copying
        /// backups</a> in the <i>Amazon FSx for Lustre User Guide</i>, and <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/using-backups.html#copy-backups">Copying
        /// backups</a> in the <i>Amazon FSx for OpenZFS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyBackup service method.</param>
        /// 
        /// <returns>The response from the CopyBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleRegionForMultiAZException">
        /// Amazon FSx doesn't support Multi-AZ Windows File Server copy backup in the destination
        /// Region, so the copied backup can't be restored.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidDestinationKmsKeyException">
        /// The Key Management Service (KMS) key of the destination backup is not valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidRegionException">
        /// The Region provided for <code>SourceRegion</code> is not valid or is in a different
        /// Amazon Web Services partition.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidSourceKmsKeyException">
        /// The Key Management Service (KMS) key of the source backup is not valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.SourceBackupUnavailableException">
        /// The request was rejected because the lifecycle status of the source backup isn't <code>AVAILABLE</code>.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CopyBackup">REST API Reference for CopyBackup Operation</seealso>
        CopyBackupResponse CopyBackup(CopyBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyBackup operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CopyBackup">REST API Reference for CopyBackup Operation</seealso>
        IAsyncResult BeginCopyBackup(CopyBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyBackup.</param>
        /// 
        /// <returns>Returns a  CopyBackupResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CopyBackup">REST API Reference for CopyBackup Operation</seealso>
        CopyBackupResponse EndCopyBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBackup


        /// <summary>
        /// Creates a backup of an existing Amazon FSx for Windows File Server file system, Amazon
        /// FSx for Lustre file system, Amazon FSx for NetApp ONTAP volume, or Amazon FSx for
        /// OpenZFS file system. We recommend creating regular backups so that you can restore
        /// a file system or volume from a backup if an issue arises with the original file system
        /// or volume.
        /// 
        ///  
        /// <para>
        /// For Amazon FSx for Lustre file systems, you can create a backup only for file systems
        /// that have the following configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A Persistent deployment type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Are <i>not</i> linked to a data repository
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about backups, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Amazon FSx for Lustre, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-backups-fsx.html">Working
        /// with FSx for Lustre backups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon FSx for Windows, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-backups.html">Working
        /// with FSx for Windows backups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon FSx for NetApp ONTAP, see <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/using-backups.html">Working
        /// with FSx for NetApp ONTAP backups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon FSx for OpenZFS, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/using-backups.html">Working
        /// with FSx for OpenZFS backups</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a backup with the specified client request token exists and the parameters match,
        /// this operation returns the description of the existing backup. If a backup with the
        /// specified client request token exists and the parameters don't match, this operation
        /// returns <code>IncompatibleParameterError</code>. If a backup with the specified client
        /// request token doesn't exist, <code>CreateBackup</code> does the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new Amazon FSx backup with an assigned ID, and an initial lifecycle state
        /// of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the backup.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateBackup</code> operation
        /// without the risk of creating an extra backup. This approach can be useful when an
        /// initial call fails in a way that makes it unclear whether a backup was created. If
        /// you use the same client request token and the initial call created a backup, the operation
        /// returns a successful result because all the parameters are the same.
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateBackup</code> operation returns while the backup's lifecycle state
        /// is still <code>CREATING</code>. You can check the backup creation status by calling
        /// the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeBackups.html">DescribeBackups</a>
        /// operation, which returns the backup state along with other information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup service method.</param>
        /// 
        /// <returns>The response from the CreateBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupInProgressException">
        /// Another backup is already under way. Wait for completion before initiating additional
        /// backups of this file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx for NetApp ONTAP volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        CreateBackupResponse CreateBackup(CreateBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        IAsyncResult BeginCreateBackup(CreateBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackup.</param>
        /// 
        /// <returns>Returns a  CreateBackupResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        CreateBackupResponse EndCreateBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataRepositoryAssociation


        /// <summary>
        /// Creates an Amazon FSx for Lustre data repository association (DRA). A data repository
        /// association is a link between a directory on the file system and an Amazon S3 bucket
        /// or prefix. You can have a maximum of 8 data repository associations on a file system.
        /// Data repository associations are supported only for file systems with the <code>Persistent_2</code>
        /// deployment type.
        /// 
        ///  
        /// <para>
        /// Each data repository association must have a unique Amazon FSx file system directory
        /// and a unique S3 bucket or prefix associated with it. You can configure a data repository
        /// association for automatic import only, for automatic export only, or for both. To
        /// learn more about linking a data repository to your file system, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/create-dra-linked-data-repo.html">Linking
        /// your file system to an S3 bucket</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRepositoryAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateDataRepositoryAssociation service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryAssociation">REST API Reference for CreateDataRepositoryAssociation Operation</seealso>
        CreateDataRepositoryAssociationResponse CreateDataRepositoryAssociation(CreateDataRepositoryAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRepositoryAssociation operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataRepositoryAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryAssociation">REST API Reference for CreateDataRepositoryAssociation Operation</seealso>
        IAsyncResult BeginCreateDataRepositoryAssociation(CreateDataRepositoryAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataRepositoryAssociation.</param>
        /// 
        /// <returns>Returns a  CreateDataRepositoryAssociationResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryAssociation">REST API Reference for CreateDataRepositoryAssociation Operation</seealso>
        CreateDataRepositoryAssociationResponse EndCreateDataRepositoryAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataRepositoryTask


        /// <summary>
        /// Creates an Amazon FSx for Lustre data repository task. You use data repository tasks
        /// to perform bulk operations between your Amazon FSx file system and its linked data
        /// repositories. An example of a data repository task is exporting any data and metadata
        /// changes, including POSIX metadata, to files, directories, and symbolic links (symlinks)
        /// from your FSx file system to a linked data repository. A <code>CreateDataRepositoryTask</code>
        /// operation will fail if a data repository is not linked to the FSx file system. To
        /// learn more about data repository tasks, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-repository-tasks.html">Data
        /// Repository Tasks</a>. To learn more about linking a data repository to your file system,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/create-dra-linked-data-repo.html">Linking
        /// your file system to an S3 bucket</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRepositoryTask service method.</param>
        /// 
        /// <returns>The response from the CreateDataRepositoryTask service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskExecutingException">
        /// An existing data repository task is currently executing on the file system. Wait until
        /// the existing task has completed, then create the new task.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryTask">REST API Reference for CreateDataRepositoryTask Operation</seealso>
        CreateDataRepositoryTaskResponse CreateDataRepositoryTask(CreateDataRepositoryTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataRepositoryTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRepositoryTask operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataRepositoryTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryTask">REST API Reference for CreateDataRepositoryTask Operation</seealso>
        IAsyncResult BeginCreateDataRepositoryTask(CreateDataRepositoryTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataRepositoryTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataRepositoryTask.</param>
        /// 
        /// <returns>Returns a  CreateDataRepositoryTaskResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryTask">REST API Reference for CreateDataRepositoryTask Operation</seealso>
        CreateDataRepositoryTaskResponse EndCreateDataRepositoryTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFileSystem


        /// <summary>
        /// Creates a new, empty Amazon FSx file system. You can create the following supported
        /// Amazon FSx file systems using the <code>CreateFileSystem</code> API operation:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Amazon FSx for Lustre
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for NetApp ONTAP
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx for Windows File Server
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation requires a client request token in the request that Amazon FSx uses
        /// to ensure idempotent creation. This means that calling the operation multiple times
        /// with the same client request token has no effect. By using the idempotent operation,
        /// you can retry a <code>CreateFileSystem</code> operation without the risk of creating
        /// an extra file system. This approach can be useful when an initial call fails in a
        /// way that makes it unclear whether a file system was created. Examples are if a transport
        /// level timeout occurred, or your connection was reset. If you use the same client request
        /// token and the initial call created a file system, the client receives success as long
        /// as the parameters are the same.
        /// </para>
        ///  
        /// <para>
        /// If a file system with the specified client request token exists and the parameters
        /// match, <code>CreateFileSystem</code> returns the description of the existing file
        /// system. If a file system with the specified client request token exists and the parameters
        /// don't match, this call returns <code>IncompatibleParameterError</code>. If a file
        /// system with the specified client request token doesn't exist, <code>CreateFileSystem</code>
        /// does the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty Amazon FSx file system with an assigned ID, and an initial lifecycle
        /// state of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation requires a client request token in the request that Amazon FSx uses
        /// to ensure idempotent creation. This means that calling the operation multiple times
        /// with the same client request token has no effect. By using the idempotent operation,
        /// you can retry a <code>CreateFileSystem</code> operation without the risk of creating
        /// an extra file system. This approach can be useful when an initial call fails in a
        /// way that makes it unclear whether a file system was created. Examples are if a transport-level
        /// timeout occurred, or your connection was reset. If you use the same client request
        /// token and the initial call created a file system, the client receives a success message
        /// as long as the parameters are the same.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
        /// is still <code>CREATING</code>. You can check the file-system creation status by calling
        /// the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">DescribeFileSystems</a>
        /// operation, which returns the file system state along with other information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem service method.</param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidExportPathException">
        /// The path provided for data repository export isn't valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidImportPathException">
        /// The path provided for data repository import isn't valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidPerUnitStorageThroughputException">
        /// An invalid value for <code>PerUnitStorageThroughput</code> was provided. Please create
        /// your file system again, using a valid value.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// A file system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFileSystem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFileSystem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        IAsyncResult BeginCreateFileSystem(CreateFileSystemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFileSystem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFileSystem.</param>
        /// 
        /// <returns>Returns a  CreateFileSystemResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        CreateFileSystemResponse EndCreateFileSystem(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFileSystemFromBackup


        /// <summary>
        /// Creates a new Amazon FSx for Lustre, Amazon FSx for Windows File Server, or Amazon
        /// FSx for OpenZFS file system from an existing Amazon FSx backup.
        /// 
        ///  
        /// <para>
        /// If a file system with the specified client request token exists and the parameters
        /// match, this operation returns the description of the file system. If a client request
        /// token with the specified by the file system exists and the parameters don't match,
        /// this call returns <code>IncompatibleParameterError</code>. If a file system with the
        /// specified client request token doesn't exist, this operation does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new Amazon FSx file system from backup with an assigned ID, and an initial
        /// lifecycle state of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Parameters like the Active Directory, default share name, automatic backup, and backup
        /// settings default to the parameters of the file system that was backed up, unless overridden.
        /// You can explicitly supply other settings.
        /// </para>
        ///  
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateFileSystemFromBackup</code>
        /// call without the risk of creating an extra file system. This approach can be useful
        /// when an initial call fails in a way that makes it unclear whether a file system was
        /// created. Examples are if a transport level timeout occurred, or your connection was
        /// reset. If you use the same client request token and the initial call created a file
        /// system, the client receives a success message as long as the parameters are the same.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystemFromBackup</code> call returns while the file system's lifecycle
        /// state is still <code>CREATING</code>. You can check the file-system creation status
        /// by calling the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">
        /// DescribeFileSystems</a> operation, which returns the file system state along with
        /// other information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystemFromBackup service method.</param>
        /// 
        /// <returns>The response from the CreateFileSystemFromBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidPerUnitStorageThroughputException">
        /// An invalid value for <code>PerUnitStorageThroughput</code> was provided. Please create
        /// your file system again, using a valid value.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// A file system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystemFromBackup">REST API Reference for CreateFileSystemFromBackup Operation</seealso>
        CreateFileSystemFromBackupResponse CreateFileSystemFromBackup(CreateFileSystemFromBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFileSystemFromBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystemFromBackup operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFileSystemFromBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystemFromBackup">REST API Reference for CreateFileSystemFromBackup Operation</seealso>
        IAsyncResult BeginCreateFileSystemFromBackup(CreateFileSystemFromBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFileSystemFromBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFileSystemFromBackup.</param>
        /// 
        /// <returns>Returns a  CreateFileSystemFromBackupResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystemFromBackup">REST API Reference for CreateFileSystemFromBackup Operation</seealso>
        CreateFileSystemFromBackupResponse EndCreateFileSystemFromBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSnapshot


        /// <summary>
        /// Creates a snapshot of an existing Amazon FSx for OpenZFS file system. With snapshots,
        /// you can easily undo file changes and compare file versions by restoring the volume
        /// to a previous version.
        /// 
        ///  
        /// <para>
        /// If a snapshot with the specified client request token exists, and the parameters match,
        /// this operation returns the description of the existing snapshot. If a snapshot with
        /// the specified client request token exists, and the parameters don't match, this operation
        /// returns <code>IncompatibleParameterError</code>. If a snapshot with the specified
        /// client request token doesn't exist, <code>CreateSnapshot</code> does the following:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new OpenZFS snapshot with an assigned ID, and an initial lifecycle state
        /// of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the snapshot.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateSnapshot</code> operation
        /// without the risk of creating an extra snapshot. This approach can be useful when an
        /// initial call fails in a way that makes it unclear whether a snapshot was created.
        /// If you use the same client request token and the initial call created a snapshot,
        /// the operation returns a successful result because all the parameters are the same.
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateSnapshot</code> operation returns while the snapshot's lifecycle state
        /// is still <code>CREATING</code>. You can check the snapshot creation status by calling
        /// the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeSnapshots.html">DescribeSnapshots</a>
        /// operation, which returns the snapshot state along with other information. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx for NetApp ONTAP volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStorageVirtualMachine


        /// <summary>
        /// Creates a storage virtual machine (SVM) for an Amazon FSx for ONTAP file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageVirtualMachine service method.</param>
        /// 
        /// <returns>The response from the CreateStorageVirtualMachine service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateStorageVirtualMachine">REST API Reference for CreateStorageVirtualMachine Operation</seealso>
        CreateStorageVirtualMachineResponse CreateStorageVirtualMachine(CreateStorageVirtualMachineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageVirtualMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageVirtualMachine operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorageVirtualMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateStorageVirtualMachine">REST API Reference for CreateStorageVirtualMachine Operation</seealso>
        IAsyncResult BeginCreateStorageVirtualMachine(CreateStorageVirtualMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorageVirtualMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageVirtualMachine.</param>
        /// 
        /// <returns>Returns a  CreateStorageVirtualMachineResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateStorageVirtualMachine">REST API Reference for CreateStorageVirtualMachine Operation</seealso>
        CreateStorageVirtualMachineResponse EndCreateStorageVirtualMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVolume


        /// <summary>
        /// Creates an Amazon FSx for NetApp ONTAP or Amazon FSx for OpenZFS storage volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingVolumeConfigurationException">
        /// A volume configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No Amazon FSx for NetApp ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        CreateVolumeResponse CreateVolume(CreateVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        IAsyncResult BeginCreateVolume(CreateVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVolume.</param>
        /// 
        /// <returns>Returns a  CreateVolumeResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        CreateVolumeResponse EndCreateVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVolumeFromBackup


        /// <summary>
        /// Creates a new Amazon FSx for NetApp ONTAP volume from an existing Amazon FSx volume
        /// backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolumeFromBackup service method.</param>
        /// 
        /// <returns>The response from the CreateVolumeFromBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingVolumeConfigurationException">
        /// A volume configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No Amazon FSx for NetApp ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateVolumeFromBackup">REST API Reference for CreateVolumeFromBackup Operation</seealso>
        CreateVolumeFromBackupResponse CreateVolumeFromBackup(CreateVolumeFromBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolumeFromBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolumeFromBackup operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVolumeFromBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateVolumeFromBackup">REST API Reference for CreateVolumeFromBackup Operation</seealso>
        IAsyncResult BeginCreateVolumeFromBackup(CreateVolumeFromBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVolumeFromBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVolumeFromBackup.</param>
        /// 
        /// <returns>Returns a  CreateVolumeFromBackupResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateVolumeFromBackup">REST API Reference for CreateVolumeFromBackup Operation</seealso>
        CreateVolumeFromBackupResponse EndCreateVolumeFromBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBackup


        /// <summary>
        /// Deletes an Amazon FSx backup. After deletion, the backup no longer exists, and its
        /// data is gone.
        /// 
        ///  
        /// <para>
        /// The <code>DeleteBackup</code> call returns instantly. The backup won't show up in
        /// later <code>DescribeBackups</code> calls.
        /// </para>
        ///  <important> 
        /// <para>
        /// The data in a deleted backup is also deleted and can't be recovered by any means.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// 
        /// <returns>The response from the DeleteBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupBeingCopiedException">
        /// You can't delete a backup while it's being copied.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupInProgressException">
        /// Another backup is already under way. Wait for completion before initiating additional
        /// backups of this file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupRestoringException">
        /// You can't delete a backup while it's being used to restore a file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        DeleteBackupResponse DeleteBackup(DeleteBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        IAsyncResult BeginDeleteBackup(DeleteBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackup.</param>
        /// 
        /// <returns>Returns a  DeleteBackupResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        DeleteBackupResponse EndDeleteBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataRepositoryAssociation


        /// <summary>
        /// Deletes a data repository association on an Amazon FSx for Lustre file system. Deleting
        /// the data repository association unlinks the file system from the Amazon S3 bucket.
        /// When deleting a data repository association, you have the option of deleting the data
        /// in the file system that corresponds to the data repository association. Data repository
        /// associations are supported only for file systems with the <code>Persistent_2</code>
        /// deployment type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataRepositoryAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteDataRepositoryAssociation service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryAssociationNotFoundException">
        /// No data repository associations were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteDataRepositoryAssociation">REST API Reference for DeleteDataRepositoryAssociation Operation</seealso>
        DeleteDataRepositoryAssociationResponse DeleteDataRepositoryAssociation(DeleteDataRepositoryAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataRepositoryAssociation operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataRepositoryAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteDataRepositoryAssociation">REST API Reference for DeleteDataRepositoryAssociation Operation</seealso>
        IAsyncResult BeginDeleteDataRepositoryAssociation(DeleteDataRepositoryAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataRepositoryAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteDataRepositoryAssociationResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteDataRepositoryAssociation">REST API Reference for DeleteDataRepositoryAssociation Operation</seealso>
        DeleteDataRepositoryAssociationResponse EndDeleteDataRepositoryAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFileSystem


        /// <summary>
        /// Deletes a file system. After deletion, the file system no longer exists, and its data
        /// is gone. Any existing automatic backups and snapshots are also deleted.
        /// 
        ///  
        /// <para>
        /// To delete an Amazon FSx for NetApp ONTAP file system, first delete all the volumes
        /// and storage virtual machines (SVMs) on the file system. Then provide a <code>FileSystemId</code>
        /// value to the <code>DeleFileSystem</code> operation.
        /// </para>
        ///  
        /// <para>
        /// By default, when you delete an Amazon FSx for Windows File Server file system, a final
        /// backup is created upon deletion. This final backup isn't subject to the file system's
        /// retention policy, and must be manually deleted.
        /// </para>
        ///  
        /// <para>
        /// The <code>DeleteFileSystem</code> operation returns while the file system has the
        /// <code>DELETING</code> status. You can check the file system deletion status by calling
        /// the <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_DescribeFileSystems.html">DescribeFileSystems</a>
        /// operation, which returns a list of file systems in your account. If you pass the file
        /// system ID for a deleted file system, the <code>DescribeFileSystems</code> operation
        /// returns a <code>FileSystemNotFound</code> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a data repository task is in a <code>PENDING</code> or <code>EXECUTING</code> state,
        /// deleting an Amazon FSx for Lustre file system will fail with an HTTP status code 400
        /// (Bad Request).
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// The data in a deleted file system is also deleted and can't be recovered by any means.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem service method.</param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFileSystem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFileSystem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        IAsyncResult BeginDeleteFileSystem(DeleteFileSystemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFileSystem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFileSystem.</param>
        /// 
        /// <returns>Returns a  DeleteFileSystemResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        DeleteFileSystemResponse EndDeleteFileSystem(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSnapshot


        /// <summary>
        /// Deletes the Amazon FSx snapshot. After deletion, the snapshot no longer exists, and
        /// its data is gone. Deleting a snapshot doesn't affect snapshots stored in a file system
        /// backup. 
        /// 
        ///  
        /// <para>
        /// The <code>DeleteSnapshot</code> operation returns instantly. The snapshot appears
        /// with the lifecycle status of <code>DELETING</code> until the deletion is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.SnapshotNotFoundException">
        /// No Amazon FSx snapshots were found based on the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStorageVirtualMachine


        /// <summary>
        /// Deletes an existing Amazon FSx for ONTAP storage virtual machine (SVM). Prior to deleting
        /// an SVM, you must delete all non-root volumes in the SVM, otherwise the operation will
        /// fail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageVirtualMachine service method.</param>
        /// 
        /// <returns>The response from the DeleteStorageVirtualMachine service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No Amazon FSx for NetApp ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteStorageVirtualMachine">REST API Reference for DeleteStorageVirtualMachine Operation</seealso>
        DeleteStorageVirtualMachineResponse DeleteStorageVirtualMachine(DeleteStorageVirtualMachineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStorageVirtualMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageVirtualMachine operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStorageVirtualMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteStorageVirtualMachine">REST API Reference for DeleteStorageVirtualMachine Operation</seealso>
        IAsyncResult BeginDeleteStorageVirtualMachine(DeleteStorageVirtualMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStorageVirtualMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStorageVirtualMachine.</param>
        /// 
        /// <returns>Returns a  DeleteStorageVirtualMachineResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteStorageVirtualMachine">REST API Reference for DeleteStorageVirtualMachine Operation</seealso>
        DeleteStorageVirtualMachineResponse EndDeleteStorageVirtualMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVolume


        /// <summary>
        /// Deletes an Amazon FSx for NetApp ONTAP or Amazon FSx for OpenZFS volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx for NetApp ONTAP volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        IAsyncResult BeginDeleteVolume(DeleteVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        /// 
        /// <returns>Returns a  DeleteVolumeResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBackups


        /// <summary>
        /// Returns the description of a specific Amazon FSx backup, if a <code>BackupIds</code>
        /// value is provided for that backup. Otherwise, it returns all backups owned by your
        /// Amazon Web Services account in the Amazon Web Services Region of the endpoint that
        /// you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all backups, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of backups in a response. If more backups remain, Amazon
        /// FSx returns a <code>NextToken</code> value in the response. In this case, send a later
        /// request with the <code>NextToken</code> request parameter set to the value of the
        /// <code>NextToken</code> value from the last response.
        /// </para>
        ///  
        /// <para>
        /// This operation is used in an iterative process to retrieve a list of your backups.
        /// <code>DescribeBackups</code> is called first without a <code>NextToken</code> value.
        /// Then the operation continues to be called with the <code>NextToken</code> parameter
        /// set to the value of the last <code>NextToken</code> value until a response has no
        /// <code>NextToken</code> value.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The operation might return fewer than the <code>MaxResults</code> value of backup
        /// descriptions while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of the backups returned in the response of one <code>DescribeBackups</code>
        /// call and the order of the backups returned across the responses of a multi-call iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups service method.</param>
        /// 
        /// <returns>The response from the DescribeBackups service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx for NetApp ONTAP volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBackups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        IAsyncResult BeginDescribeBackups(DescribeBackupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBackups.</param>
        /// 
        /// <returns>Returns a  DescribeBackupsResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        DescribeBackupsResponse EndDescribeBackups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataRepositoryAssociations


        /// <summary>
        /// Returns the description of specific Amazon FSx for Lustre data repository associations,
        /// if one or more <code>AssociationIds</code> values are provided in the request, or
        /// if filters are used in the request. Data repository associations are supported only
        /// for file systems with the <code>Persistent_2</code> deployment type.
        /// 
        ///  
        /// <para>
        /// You can use filters to narrow the response to include just data repository associations
        /// for specific file systems (use the <code>file-system-id</code> filter with the ID
        /// of the file system) or data repository associations for a specific repository type
        /// (use the <code>data-repository-type</code> filter with a value of <code>S3</code>).
        /// If you don't use filters, the response returns all data repository associations owned
        /// by your Amazon Web Services account in the Amazon Web Services Region of the endpoint
        /// that you're calling.
        /// </para>
        ///  
        /// <para>
        /// When retrieving all data repository associations, you can paginate the response by
        /// using the optional <code>MaxResults</code> parameter to limit the number of data repository
        /// associations returned in a response. If more data repository associations remain,
        /// Amazon FSx returns a <code>NextToken</code> value in the response. In this case, send
        /// a later request with the <code>NextToken</code> request parameter set to the value
        /// of <code>NextToken</code> from the last response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataRepositoryAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeDataRepositoryAssociations service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryAssociationNotFoundException">
        /// No data repository associations were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidDataRepositoryTypeException">
        /// You have filtered the response to a data repository type that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryAssociations">REST API Reference for DescribeDataRepositoryAssociations Operation</seealso>
        DescribeDataRepositoryAssociationsResponse DescribeDataRepositoryAssociations(DescribeDataRepositoryAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataRepositoryAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataRepositoryAssociations operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataRepositoryAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryAssociations">REST API Reference for DescribeDataRepositoryAssociations Operation</seealso>
        IAsyncResult BeginDescribeDataRepositoryAssociations(DescribeDataRepositoryAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataRepositoryAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataRepositoryAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeDataRepositoryAssociationsResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryAssociations">REST API Reference for DescribeDataRepositoryAssociations Operation</seealso>
        DescribeDataRepositoryAssociationsResponse EndDescribeDataRepositoryAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataRepositoryTasks


        /// <summary>
        /// Returns the description of specific Amazon FSx for Lustre data repository tasks, if
        /// one or more <code>TaskIds</code> values are provided in the request, or if filters
        /// are used in the request. You can use filters to narrow the response to include just
        /// tasks for specific file systems, or tasks in a specific lifecycle state. Otherwise,
        /// it returns all data repository tasks owned by your Amazon Web Services account in
        /// the Amazon Web Services Region of the endpoint that you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all tasks, you can paginate the response by using the optional <code>MaxResults</code>
        /// parameter to limit the number of tasks returned in a response. If more tasks remain,
        /// Amazon FSx returns a <code>NextToken</code> value in the response. In this case, send
        /// a later request with the <code>NextToken</code> request parameter set to the value
        /// of <code>NextToken</code> from the last response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataRepositoryTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeDataRepositoryTasks service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskNotFoundException">
        /// The data repository task or tasks you specified could not be found.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryTasks">REST API Reference for DescribeDataRepositoryTasks Operation</seealso>
        DescribeDataRepositoryTasksResponse DescribeDataRepositoryTasks(DescribeDataRepositoryTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataRepositoryTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataRepositoryTasks operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataRepositoryTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryTasks">REST API Reference for DescribeDataRepositoryTasks Operation</seealso>
        IAsyncResult BeginDescribeDataRepositoryTasks(DescribeDataRepositoryTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataRepositoryTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataRepositoryTasks.</param>
        /// 
        /// <returns>Returns a  DescribeDataRepositoryTasksResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryTasks">REST API Reference for DescribeDataRepositoryTasks Operation</seealso>
        DescribeDataRepositoryTasksResponse EndDescribeDataRepositoryTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFileSystemAliases


        /// <summary>
        /// Returns the DNS aliases that are associated with the specified Amazon FSx for Windows
        /// File Server file system. A history of all DNS aliases that have been associated with
        /// and disassociated from the file system is available in the list of <a>AdministrativeAction</a>
        /// provided in the <a>DescribeFileSystems</a> operation response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystemAliases service method.</param>
        /// 
        /// <returns>The response from the DescribeFileSystemAliases service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystemAliases">REST API Reference for DescribeFileSystemAliases Operation</seealso>
        DescribeFileSystemAliasesResponse DescribeFileSystemAliases(DescribeFileSystemAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystemAliases operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFileSystemAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystemAliases">REST API Reference for DescribeFileSystemAliases Operation</seealso>
        IAsyncResult BeginDescribeFileSystemAliases(DescribeFileSystemAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFileSystemAliases.</param>
        /// 
        /// <returns>Returns a  DescribeFileSystemAliasesResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystemAliases">REST API Reference for DescribeFileSystemAliases Operation</seealso>
        DescribeFileSystemAliasesResponse EndDescribeFileSystemAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFileSystems


        /// <summary>
        /// Returns the description of specific Amazon FSx file systems, if a <code>FileSystemIds</code>
        /// value is provided for that file system. Otherwise, it returns descriptions of all
        /// file systems owned by your Amazon Web Services account in the Amazon Web Services
        /// Region of the endpoint that you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all file system descriptions, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of descriptions in a response. If more file system descriptions
        /// remain, Amazon FSx returns a <code>NextToken</code> value in the response. In this
        /// case, send a later request with the <code>NextToken</code> request parameter set to
        /// the value of <code>NextToken</code> from the last response.
        /// </para>
        ///  
        /// <para>
        /// This operation is used in an iterative process to retrieve a list of your file system
        /// descriptions. <code>DescribeFileSystems</code> is called first without a <code>NextToken</code>value.
        /// Then the operation continues to be called with the <code>NextToken</code> parameter
        /// set to the value of the last <code>NextToken</code> value until a response has no
        /// <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of file systems returned in the response of one <code>DescribeFileSystems</code>
        /// call and the order of file systems returned across the responses of a multicall iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems service method.</param>
        /// 
        /// <returns>The response from the DescribeFileSystems service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        DescribeFileSystemsResponse DescribeFileSystems(DescribeFileSystemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFileSystems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFileSystems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        IAsyncResult BeginDescribeFileSystems(DescribeFileSystemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFileSystems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFileSystems.</param>
        /// 
        /// <returns>Returns a  DescribeFileSystemsResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        DescribeFileSystemsResponse EndDescribeFileSystems(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSnapshots


        /// <summary>
        /// Returns the description of specific Amazon FSx snapshots, if a <code>SnapshotIds</code>
        /// value is provided. Otherwise, this operation returns all snapshots owned by your Amazon
        /// Web Services account in the Amazon Web Services Region of the endpoint that you're
        /// calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all snapshots, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of snapshots in a response. If more backups remain,
        /// Amazon FSx returns a <code>NextToken</code> value in the response. In this case, send
        /// a later request with the <code>NextToken</code> request parameter set to the value
        /// of <code>NextToken</code> from the last response. 
        /// </para>
        ///  
        /// <para>
        /// Use this operation in an iterative process to retrieve a list of your snapshots. <code>DescribeSnapshots</code>
        /// is called first without a <code>NextToken</code> value. Then the operation continues
        /// to be called with the <code>NextToken</code> parameter set to the value of the last
        /// <code>NextToken</code> value until a response has no <code>NextToken</code> value.
        /// </para>
        ///  
        /// <para>
        /// When using this operation, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The operation might return fewer than the <code>MaxResults</code> value of snapshot
        /// descriptions while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of snapshots returned in the response of one <code>DescribeSnapshots</code>
        /// call and the order of backups returned across the responses of a multi-call iteration
        /// is unspecified. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.SnapshotNotFoundException">
        /// No Amazon FSx snapshots were found based on the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotsResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStorageVirtualMachines


        /// <summary>
        /// Describes one or more Amazon FSx for NetApp ONTAP storage virtual machines (SVMs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageVirtualMachines service method.</param>
        /// 
        /// <returns>The response from the DescribeStorageVirtualMachines service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No Amazon FSx for NetApp ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeStorageVirtualMachines">REST API Reference for DescribeStorageVirtualMachines Operation</seealso>
        DescribeStorageVirtualMachinesResponse DescribeStorageVirtualMachines(DescribeStorageVirtualMachinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStorageVirtualMachines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageVirtualMachines operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStorageVirtualMachines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeStorageVirtualMachines">REST API Reference for DescribeStorageVirtualMachines Operation</seealso>
        IAsyncResult BeginDescribeStorageVirtualMachines(DescribeStorageVirtualMachinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStorageVirtualMachines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStorageVirtualMachines.</param>
        /// 
        /// <returns>Returns a  DescribeStorageVirtualMachinesResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeStorageVirtualMachines">REST API Reference for DescribeStorageVirtualMachines Operation</seealso>
        DescribeStorageVirtualMachinesResponse EndDescribeStorageVirtualMachines(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVolumes


        /// <summary>
        /// Describes one or more Amazon FSx for NetApp ONTAP or Amazon FSx for OpenZFS volumes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx for NetApp ONTAP volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeVolumesResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFileSystemAliases


        /// <summary>
        /// Use this action to disassociate, or remove, one or more Domain Name Service (DNS)
        /// aliases from an Amazon FSx for Windows File Server file system. If you attempt to
        /// disassociate a DNS alias that is not associated with the file system, Amazon FSx responds
        /// with a 400 Bad Request. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">Working
        /// with DNS Aliases</a>.
        /// 
        ///  
        /// <para>
        /// The system generated response showing the DNS aliases that Amazon FSx is attempting
        /// to disassociate from the file system. Use the API operation to monitor the status
        /// of the aliases Amazon FSx is disassociating with the file system.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFileSystemAliases service method.</param>
        /// 
        /// <returns>The response from the DisassociateFileSystemAliases service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DisassociateFileSystemAliases">REST API Reference for DisassociateFileSystemAliases Operation</seealso>
        DisassociateFileSystemAliasesResponse DisassociateFileSystemAliases(DisassociateFileSystemAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFileSystemAliases operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFileSystemAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DisassociateFileSystemAliases">REST API Reference for DisassociateFileSystemAliases Operation</seealso>
        IAsyncResult BeginDisassociateFileSystemAliases(DisassociateFileSystemAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFileSystemAliases.</param>
        /// 
        /// <returns>Returns a  DisassociateFileSystemAliasesResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DisassociateFileSystemAliases">REST API Reference for DisassociateFileSystemAliases Operation</seealso>
        DisassociateFileSystemAliasesResponse EndDisassociateFileSystemAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for an Amazon FSx file systems and backups in the case of Amazon FSx for
        /// Windows File Server.
        /// 
        ///  
        /// <para>
        /// When retrieving all tags, you can optionally specify the <code>MaxResults</code> parameter
        /// to limit the number of tags in a response. If more tags remain, Amazon FSx returns
        /// a <code>NextToken</code> value in the response. In this case, send a later request
        /// with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
        /// from the last response.
        /// </para>
        ///  
        /// <para>
        /// This action is used in an iterative process to retrieve a list of your tags. <code>ListTagsForResource</code>
        /// is called first without a <code>NextToken</code>value. Then the action continues to
        /// be called with the <code>NextToken</code> parameter set to the value of the last <code>NextToken</code>
        /// value until a response has no <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this action, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of tags returned in the response of one <code>ListTagsForResource</code>
        /// call and the order of tags returned across the responses of a multi-call iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ReleaseFileSystemNfsV3Locks


        /// <summary>
        /// Releases the file system lock from an Amazon FSx for OpenZFS file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseFileSystemNfsV3Locks service method.</param>
        /// 
        /// <returns>The response from the ReleaseFileSystemNfsV3Locks service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ReleaseFileSystemNfsV3Locks">REST API Reference for ReleaseFileSystemNfsV3Locks Operation</seealso>
        ReleaseFileSystemNfsV3LocksResponse ReleaseFileSystemNfsV3Locks(ReleaseFileSystemNfsV3LocksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseFileSystemNfsV3Locks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseFileSystemNfsV3Locks operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReleaseFileSystemNfsV3Locks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ReleaseFileSystemNfsV3Locks">REST API Reference for ReleaseFileSystemNfsV3Locks Operation</seealso>
        IAsyncResult BeginReleaseFileSystemNfsV3Locks(ReleaseFileSystemNfsV3LocksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReleaseFileSystemNfsV3Locks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseFileSystemNfsV3Locks.</param>
        /// 
        /// <returns>Returns a  ReleaseFileSystemNfsV3LocksResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ReleaseFileSystemNfsV3Locks">REST API Reference for ReleaseFileSystemNfsV3Locks Operation</seealso>
        ReleaseFileSystemNfsV3LocksResponse EndReleaseFileSystemNfsV3Locks(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreVolumeFromSnapshot


        /// <summary>
        /// Returns an Amazon FSx for OpenZFS volume to the state saved by the specified snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreVolumeFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreVolumeFromSnapshot service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx for NetApp ONTAP volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/RestoreVolumeFromSnapshot">REST API Reference for RestoreVolumeFromSnapshot Operation</seealso>
        RestoreVolumeFromSnapshotResponse RestoreVolumeFromSnapshot(RestoreVolumeFromSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreVolumeFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreVolumeFromSnapshot operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreVolumeFromSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/RestoreVolumeFromSnapshot">REST API Reference for RestoreVolumeFromSnapshot Operation</seealso>
        IAsyncResult BeginRestoreVolumeFromSnapshot(RestoreVolumeFromSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreVolumeFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreVolumeFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreVolumeFromSnapshotResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/RestoreVolumeFromSnapshot">REST API Reference for RestoreVolumeFromSnapshot Operation</seealso>
        RestoreVolumeFromSnapshotResponse EndRestoreVolumeFromSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags an Amazon FSx resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// This action removes a tag from an Amazon FSx resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataRepositoryAssociation


        /// <summary>
        /// Updates the configuration of an existing data repository association on an Amazon
        /// FSx for Lustre file system. Data repository associations are supported only for file
        /// systems with the <code>Persistent_2</code> deployment type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRepositoryAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateDataRepositoryAssociation service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryAssociationNotFoundException">
        /// No data repository associations were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateDataRepositoryAssociation">REST API Reference for UpdateDataRepositoryAssociation Operation</seealso>
        UpdateDataRepositoryAssociationResponse UpdateDataRepositoryAssociation(UpdateDataRepositoryAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRepositoryAssociation operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataRepositoryAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateDataRepositoryAssociation">REST API Reference for UpdateDataRepositoryAssociation Operation</seealso>
        IAsyncResult BeginUpdateDataRepositoryAssociation(UpdateDataRepositoryAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataRepositoryAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataRepositoryAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateDataRepositoryAssociationResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateDataRepositoryAssociation">REST API Reference for UpdateDataRepositoryAssociation Operation</seealso>
        UpdateDataRepositoryAssociationResponse EndUpdateDataRepositoryAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFileSystem


        /// <summary>
        /// Use this operation to update the configuration of an existing Amazon FSx file system.
        /// You can update multiple properties in a single request.
        /// 
        ///  
        /// <para>
        /// For Amazon FSx for Windows File Server file systems, you can update the following
        /// properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AuditLogConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AutomaticBackupRetentionDays</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DailyAutomaticBackupStartTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SelfManagedActiveDirectoryConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StorageCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ThroughputCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WeeklyMaintenanceStartTime</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For FSx for Lustre file systems, you can update the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AutoImportPolicy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AutomaticBackupRetentionDays</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DailyAutomaticBackupStartTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataCompressionType</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StorageCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WeeklyMaintenanceStartTime</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For FSx for ONTAP file systems, you can update the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AutomaticBackupRetentionDays</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DailyAutomaticBackupStartTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FsxAdminPassword</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WeeklyMaintenanceStartTime</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the Amazon FSx for OpenZFS file systems, you can update the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AutomaticBackupRetentionDays</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CopyTagsToBackups</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CopyTagsToVolumes</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DailyAutomaticBackupStartTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DiskIopsConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ThroughputCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WeeklyMaintenanceStartTime</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileSystem service method.</param>
        /// 
        /// <returns>The response from the UpdateFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// A file system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        UpdateFileSystemResponse UpdateFileSystem(UpdateFileSystemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFileSystem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileSystem operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFileSystem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        IAsyncResult BeginUpdateFileSystem(UpdateFileSystemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFileSystem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFileSystem.</param>
        /// 
        /// <returns>Returns a  UpdateFileSystemResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        UpdateFileSystemResponse EndUpdateFileSystem(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSnapshot


        /// <summary>
        /// Updates the name of a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
        /// 
        /// <returns>The response from the UpdateSnapshot service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.SnapshotNotFoundException">
        /// No Amazon FSx snapshots were found based on the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        IAsyncResult BeginUpdateSnapshot(UpdateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSnapshot.</param>
        /// 
        /// <returns>Returns a  UpdateSnapshotResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        UpdateSnapshotResponse EndUpdateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStorageVirtualMachine


        /// <summary>
        /// Updates an Amazon FSx for ONTAP storage virtual machine (SVM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageVirtualMachine service method.</param>
        /// 
        /// <returns>The response from the UpdateStorageVirtualMachine service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.StorageVirtualMachineNotFoundException">
        /// No Amazon FSx for NetApp ONTAP SVMs were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateStorageVirtualMachine">REST API Reference for UpdateStorageVirtualMachine Operation</seealso>
        UpdateStorageVirtualMachineResponse UpdateStorageVirtualMachine(UpdateStorageVirtualMachineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStorageVirtualMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageVirtualMachine operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStorageVirtualMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateStorageVirtualMachine">REST API Reference for UpdateStorageVirtualMachine Operation</seealso>
        IAsyncResult BeginUpdateStorageVirtualMachine(UpdateStorageVirtualMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStorageVirtualMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStorageVirtualMachine.</param>
        /// 
        /// <returns>Returns a  UpdateStorageVirtualMachineResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateStorageVirtualMachine">REST API Reference for UpdateStorageVirtualMachine Operation</seealso>
        UpdateStorageVirtualMachineResponse EndUpdateStorageVirtualMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVolume


        /// <summary>
        /// Updates the configuration of an Amazon FSx for NetApp ONTAP or Amazon FSx for OpenZFS
        /// volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume service method.</param>
        /// 
        /// <returns>The response from the UpdateVolume service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingVolumeConfigurationException">
        /// A volume configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.VolumeNotFoundException">
        /// No Amazon FSx for NetApp ONTAP volumes were found based upon the supplied parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVolume operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        IAsyncResult BeginUpdateVolume(UpdateVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVolume.</param>
        /// 
        /// <returns>Returns a  UpdateVolumeResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateVolume">REST API Reference for UpdateVolume Operation</seealso>
        UpdateVolumeResponse EndUpdateVolume(IAsyncResult asyncResult);

        #endregion
        
    }
}