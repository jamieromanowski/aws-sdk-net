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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Amazon.S3Control.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3Control
{
    /// <summary>
    /// Implementation for accessing S3Control
    ///
    /// Amazon Web Services S3 Control provides access to Amazon S3 control plane actions.
    /// </summary>
    public partial class AmazonS3ControlClient : AmazonServiceClient, IAmazonS3Control
    {
        private static IServiceMetadata serviceMetadata = new AmazonS3ControlMetadata();
        private IS3ControlPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IS3ControlPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new S3ControlPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3ControlClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonS3ControlClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3ControlConfig()) { }

        /// <summary>
        /// Constructs AmazonS3ControlClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonS3ControlClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3ControlConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonS3ControlClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonS3ControlClient Configuration Object</param>
        public AmazonS3ControlClient(AmazonS3ControlConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonS3ControlClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3ControlClient(AWSCredentials credentials)
            : this(credentials, new AmazonS3ControlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3ControlClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3ControlClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3ControlConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3ControlClient with AWS Credentials and an
        /// AmazonS3ControlClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3ControlClient Configuration Object</param>
        public AmazonS3ControlClient(AWSCredentials credentials, AmazonS3ControlConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3ControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3ControlClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3ControlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3ControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3ControlClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3ControlConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3ControlClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3ControlClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3ControlClient Configuration Object</param>
        public AmazonS3ControlClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3ControlConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3ControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3ControlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3ControlConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonS3ControlClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3ControlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3ControlConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3ControlClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3ControlClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3ControlClient Configuration Object</param>
        public AmazonS3ControlClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3ControlConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new S3Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3Control.Internal.AmazonS3ControlPreMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3Control.Internal.AmazonS3ControlPostMarshallHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3Control.Internal.AmazonS3ControlPostUnmarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.S3Control.Internal.AmazonS3ControlExceptionHandler());
        }    
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateAccessPoint


        /// <summary>
        /// Creates an access point and associates it with the specified bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points.html">Managing
        /// Data Access with Amazon S3 Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   <note> 
        /// <para>
        /// S3 on Outposts only supports VPC-style access points. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">
        /// Accessing Amazon S3 on Outposts using virtual private cloud (VPC) only access points</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html#API_control_CreateAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///   
        /// <para>
        /// The following actions are related to <code>CreateAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        public virtual CreateAccessPointResponse CreateAccessPoint(CreateAccessPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPointResponseUnmarshaller.Instance;

            return Invoke<CreateAccessPointResponse>(request, options);
        }


        /// <summary>
        /// Creates an access point and associates it with the specified bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points.html">Managing
        /// Data Access with Amazon S3 Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   <note> 
        /// <para>
        /// S3 on Outposts only supports VPC-style access points. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">
        /// Accessing Amazon S3 on Outposts using virtual private cloud (VPC) only access points</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html#API_control_CreateAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///   
        /// <para>
        /// The following actions are related to <code>CreateAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPoint">REST API Reference for CreateAccessPoint Operation</seealso>
        public virtual Task<CreateAccessPointResponse> CreateAccessPointAsync(CreateAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAccessPointForObjectLambda


        /// <summary>
        /// Creates an Object Lambda Access Point. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/transforming-objects.html">Transforming
        /// objects with Object Lambda Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>CreateAccessPointForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointForObjectLambda.html">DeleteAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointForObjectLambda.html">GetAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForObjectLambda.html">ListAccessPointsForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPointForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPointForObjectLambda">REST API Reference for CreateAccessPointForObjectLambda Operation</seealso>
        public virtual CreateAccessPointForObjectLambdaResponse CreateAccessPointForObjectLambda(CreateAccessPointForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPointForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPointForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<CreateAccessPointForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Creates an Object Lambda Access Point. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/transforming-objects.html">Transforming
        /// objects with Object Lambda Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>CreateAccessPointForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointForObjectLambda.html">DeleteAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointForObjectLambda.html">GetAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForObjectLambda.html">ListAccessPointsForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPointForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateAccessPointForObjectLambda">REST API Reference for CreateAccessPointForObjectLambda Operation</seealso>
        public virtual Task<CreateAccessPointForObjectLambdaResponse> CreateAccessPointForObjectLambdaAsync(CreateAccessPointForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAccessPointForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPointForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAccessPointForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBucket


        /// <summary>
        /// <note> 
        /// <para>
        /// This action creates an Amazon S3 on Outposts bucket. To create an S3 bucket, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">Create
        /// Bucket</a> in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a new Outposts bucket. By creating the bucket, you become the bucket owner.
        /// To create an Outposts bucket, you must have S3 on Outposts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Not every string is an acceptable bucket name. For information on bucket naming restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/BucketRestrictions.html#bucketnamingrules">Working
        /// with Amazon S3 Buckets</a>.
        /// </para>
        ///  
        /// <para>
        /// S3 on Outposts buckets support:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LifecycleConfigurations for deleting expired objects
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a complete list of restrictions and Amazon S3 feature limitations on S3 on Outposts,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OnOutpostsRestrictionsLimitations.html">
        /// Amazon S3 on Outposts Restrictions and Limitations</a>.
        /// </para>
        ///  
        /// <para>
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and <code>x-amz-outpost-id</code> in your API request,
        /// see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html#API_control_CreateBucket_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>CreateBucket</code> for Amazon S3 on Outposts:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html">GetBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html">DeleteBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBucket service method.</param>
        /// 
        /// <returns>The response from the CreateBucket service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BucketAlreadyExistsException">
        /// The requested Outposts bucket name is not available. The bucket namespace is shared
        /// by all users of the Outposts in this Region. Select a different name and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.BucketAlreadyOwnedByYouException">
        /// The Outposts bucket you tried to create already exists, and you own it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateBucket">REST API Reference for CreateBucket Operation</seealso>
        public virtual CreateBucketResponse CreateBucket(CreateBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBucketResponseUnmarshaller.Instance;

            return Invoke<CreateBucketResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action creates an Amazon S3 on Outposts bucket. To create an S3 bucket, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">Create
        /// Bucket</a> in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a new Outposts bucket. By creating the bucket, you become the bucket owner.
        /// To create an Outposts bucket, you must have S3 on Outposts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Not every string is an acceptable bucket name. For information on bucket naming restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/BucketRestrictions.html#bucketnamingrules">Working
        /// with Amazon S3 Buckets</a>.
        /// </para>
        ///  
        /// <para>
        /// S3 on Outposts buckets support:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LifecycleConfigurations for deleting expired objects
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a complete list of restrictions and Amazon S3 feature limitations on S3 on Outposts,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OnOutpostsRestrictionsLimitations.html">
        /// Amazon S3 on Outposts Restrictions and Limitations</a>.
        /// </para>
        ///  
        /// <para>
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and <code>x-amz-outpost-id</code> in your API request,
        /// see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html#API_control_CreateBucket_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>CreateBucket</code> for Amazon S3 on Outposts:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html">GetBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html">DeleteBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBucket service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BucketAlreadyExistsException">
        /// The requested Outposts bucket name is not available. The bucket namespace is shared
        /// by all users of the Outposts in this Region. Select a different name and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.BucketAlreadyOwnedByYouException">
        /// The Outposts bucket you tried to create already exists, and you own it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateBucket">REST API Reference for CreateBucket Operation</seealso>
        public virtual Task<CreateBucketResponse> CreateBucketAsync(CreateBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBucketResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// You can use S3 Batch Operations to perform large-scale batch actions on Amazon S3
        /// objects. Batch Operations can run a single action on lists of Amazon S3 objects that
        /// you specify. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This action creates a S3 Batch Operations job.
        /// </para>
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_JobOperation.html">JobOperation</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.IdempotencyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual CreateJobResponse CreateJob(CreateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;

            return Invoke<CreateJobResponse>(request, options);
        }


        /// <summary>
        /// You can use S3 Batch Operations to perform large-scale batch actions on Amazon S3
        /// objects. Batch Operations can run a single action on lists of Amazon S3 objects that
        /// you specify. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This action creates a S3 Batch Operations job.
        /// </para>
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_JobOperation.html">JobOperation</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.IdempotencyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateJob">REST API Reference for CreateJob Operation</seealso>
        public virtual Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMultiRegionAccessPoint


        /// <summary>
        /// Creates a Multi-Region Access Point and associates it with the specified buckets.
        /// For more information about creating Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CreatingMultiRegionAccessPoints.html">Creating
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This request is asynchronous, meaning that you might receive a response before the
        /// command has completed. When this request provides a response, it provides a token
        /// that you can use to monitor the status of the request with <code>DescribeMultiRegionAccessPointOperation</code>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>CreateMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionAccessPoint service method.</param>
        /// 
        /// <returns>The response from the CreateMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateMultiRegionAccessPoint">REST API Reference for CreateMultiRegionAccessPoint Operation</seealso>
        public virtual CreateMultiRegionAccessPointResponse CreateMultiRegionAccessPoint(CreateMultiRegionAccessPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMultiRegionAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultiRegionAccessPointResponseUnmarshaller.Instance;

            return Invoke<CreateMultiRegionAccessPointResponse>(request, options);
        }


        /// <summary>
        /// Creates a Multi-Region Access Point and associates it with the specified buckets.
        /// For more information about creating Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CreatingMultiRegionAccessPoints.html">Creating
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This request is asynchronous, meaning that you might receive a response before the
        /// command has completed. When this request provides a response, it provides a token
        /// that you can use to monitor the status of the request with <code>DescribeMultiRegionAccessPointOperation</code>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>CreateMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiRegionAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/CreateMultiRegionAccessPoint">REST API Reference for CreateMultiRegionAccessPoint Operation</seealso>
        public virtual Task<CreateMultiRegionAccessPointResponse> CreateMultiRegionAccessPointAsync(CreateMultiRegionAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMultiRegionAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMultiRegionAccessPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMultiRegionAccessPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessPoint


        /// <summary>
        /// Deletes the specified access point.
        /// 
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html#API_control_DeleteAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        public virtual DeleteAccessPointResponse DeleteAccessPoint(DeleteAccessPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPointResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified access point.
        /// 
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html#API_control_DeleteAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPoint">REST API Reference for DeleteAccessPoint Operation</seealso>
        public virtual Task<DeleteAccessPointResponse> DeleteAccessPointAsync(DeleteAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessPointForObjectLambda


        /// <summary>
        /// Deletes the specified Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteAccessPointForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPointForObjectLambda.html">CreateAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointForObjectLambda.html">GetAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForObjectLambda.html">ListAccessPointsForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointForObjectLambda">REST API Reference for DeleteAccessPointForObjectLambda Operation</seealso>
        public virtual DeleteAccessPointForObjectLambdaResponse DeleteAccessPointForObjectLambda(DeleteAccessPointForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPointForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteAccessPointForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPointForObjectLambda.html">CreateAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointForObjectLambda.html">GetAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForObjectLambda.html">ListAccessPointsForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointForObjectLambda">REST API Reference for DeleteAccessPointForObjectLambda Operation</seealso>
        public virtual Task<DeleteAccessPointForObjectLambdaResponse> DeleteAccessPointForObjectLambdaAsync(DeleteAccessPointForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessPointForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessPointPolicy


        /// <summary>
        /// Deletes the access point policy for the specified access point.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicy.html#API_control_DeleteAccessPointPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicy.html">GetAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicy">REST API Reference for DeleteAccessPointPolicy Operation</seealso>
        public virtual DeleteAccessPointPolicyResponse DeleteAccessPointPolicy(DeleteAccessPointPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPointPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the access point policy for the specified access point.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicy.html#API_control_DeleteAccessPointPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicy.html">GetAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicy">REST API Reference for DeleteAccessPointPolicy Operation</seealso>
        public virtual Task<DeleteAccessPointPolicyResponse> DeleteAccessPointPolicyAsync(DeleteAccessPointPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessPointPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessPointPolicyForObjectLambda


        /// <summary>
        /// Removes the resource policy for an Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteAccessPointPolicyForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicyForObjectLambda.html">GetAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicyForObjectLambda.html">PutAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicyForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicyForObjectLambda">REST API Reference for DeleteAccessPointPolicyForObjectLambda Operation</seealso>
        public virtual DeleteAccessPointPolicyForObjectLambdaResponse DeleteAccessPointPolicyForObjectLambda(DeleteAccessPointPolicyForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointPolicyForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointPolicyForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPointPolicyForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Removes the resource policy for an Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteAccessPointPolicyForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicyForObjectLambda.html">GetAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicyForObjectLambda.html">PutAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicyForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteAccessPointPolicyForObjectLambda">REST API Reference for DeleteAccessPointPolicyForObjectLambda Operation</seealso>
        public virtual Task<DeleteAccessPointPolicyForObjectLambdaResponse> DeleteAccessPointPolicyForObjectLambdaAsync(DeleteAccessPointPolicyForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessPointPolicyForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPointPolicyForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessPointPolicyForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucket


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket. To delete an S3 bucket, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the Amazon S3 on Outposts bucket. All objects (including all object versions
        /// and delete markers) in the bucket must be deleted before the bucket itself can be
        /// deleted. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html#API_control_DeleteBucket_Examples">Examples</a>
        /// section.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html">CreateBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html">GetBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket service method.</param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        public virtual DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket. To delete an S3 bucket, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the Amazon S3 on Outposts bucket. All objects (including all object versions
        /// and delete markers) in the bucket must be deleted before the bucket itself can be
        /// deleted. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html#API_control_DeleteBucket_Examples">Examples</a>
        /// section.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html">CreateBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html">GetBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucket">REST API Reference for DeleteBucket Operation</seealso>
        public virtual Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketLifecycleConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket's lifecycle configuration. To
        /// delete an S3 bucket's lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketLifecycle.html">DeleteBucketLifecycle</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the lifecycle configuration from the specified Outposts bucket. Amazon S3
        /// on Outposts removes all the lifecycle configuration rules in the lifecycle subresource
        /// associated with the bucket. Your objects never expire, and Amazon S3 on Outposts no
        /// longer automatically deletes any objects on the basis of rules contained in the deleted
        /// lifecycle configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3-outposts:DeleteLifecycleConfiguration</code>
        /// action. By default, the bucket owner has this permission and the Outposts bucket owner
        /// can grant this permission to others.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketLifecycleConfiguration.html#API_control_DeleteBucketLifecycleConfiguration_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// For more information about object expiration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html#intro-lifecycle-rules-actions">Elements
        /// to Describe Lifecycle Actions</a>.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketLifecycleConfiguration">REST API Reference for DeleteBucketLifecycleConfiguration Operation</seealso>
        public virtual DeleteBucketLifecycleConfigurationResponse DeleteBucketLifecycleConfiguration(DeleteBucketLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket's lifecycle configuration. To
        /// delete an S3 bucket's lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketLifecycle.html">DeleteBucketLifecycle</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the lifecycle configuration from the specified Outposts bucket. Amazon S3
        /// on Outposts removes all the lifecycle configuration rules in the lifecycle subresource
        /// associated with the bucket. Your objects never expire, and Amazon S3 on Outposts no
        /// longer automatically deletes any objects on the basis of rules contained in the deleted
        /// lifecycle configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3-outposts:DeleteLifecycleConfiguration</code>
        /// action. By default, the bucket owner has this permission and the Outposts bucket owner
        /// can grant this permission to others.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketLifecycleConfiguration.html#API_control_DeleteBucketLifecycleConfiguration_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// For more information about object expiration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html#intro-lifecycle-rules-actions">Elements
        /// to Describe Lifecycle Actions</a>.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketLifecycleConfiguration">REST API Reference for DeleteBucketLifecycleConfiguration Operation</seealso>
        public virtual Task<DeleteBucketLifecycleConfigurationResponse> DeleteBucketLifecycleConfigurationAsync(DeleteBucketLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketLifecycleConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBucketLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket policy. To delete an S3 bucket
        /// policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// This implementation of the DELETE action uses the policy subresource to delete the
        /// policy of a specified Amazon S3 on Outposts bucket. If you are using an identity other
        /// than the root user of the Amazon Web Services account that owns the bucket, the calling
        /// identity must have the <code>s3-outposts:DeleteBucketPolicy</code> permissions on
        /// the specified Outposts bucket and belong to the bucket owner's account to use this
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't have <code>DeleteBucketPolicy</code> permissions, Amazon S3 returns a
        /// <code>403 Access Denied</code> error. If you have the correct permissions, but you're
        /// not using an identity that belongs to the bucket owner's account, Amazon S3 returns
        /// a <code>405 Method Not Allowed</code> error. 
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the Amazon Web Services account that owns
        /// a bucket can always use this action, even if the policy explicitly denies the root
        /// user the ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html#API_control_DeleteBucketPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html">GetBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html">PutBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketPolicy">REST API Reference for DeleteBucketPolicy Operation</seealso>
        public virtual DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketPolicyResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket policy. To delete an S3 bucket
        /// policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// This implementation of the DELETE action uses the policy subresource to delete the
        /// policy of a specified Amazon S3 on Outposts bucket. If you are using an identity other
        /// than the root user of the Amazon Web Services account that owns the bucket, the calling
        /// identity must have the <code>s3-outposts:DeleteBucketPolicy</code> permissions on
        /// the specified Outposts bucket and belong to the bucket owner's account to use this
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't have <code>DeleteBucketPolicy</code> permissions, Amazon S3 returns a
        /// <code>403 Access Denied</code> error. If you have the correct permissions, but you're
        /// not using an identity that belongs to the bucket owner's account, Amazon S3 returns
        /// a <code>405 Method Not Allowed</code> error. 
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the Amazon Web Services account that owns
        /// a bucket can always use this action, even if the policy explicitly denies the root
        /// user the ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>. 
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html#API_control_DeleteBucketPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html">GetBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html">PutBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketPolicy">REST API Reference for DeleteBucketPolicy Operation</seealso>
        public virtual Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBucketPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketTagging


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket's tags. To delete an S3 bucket
        /// tags, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketTagging.html">DeleteBucketTagging</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the tags from the Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <code>PutBucketTagging</code>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others. 
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html#API_control_DeleteBucketTagging_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html">GetBucketTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html">PutBucketTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketTagging">REST API Reference for DeleteBucketTagging Operation</seealso>
        public virtual DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketTaggingResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action deletes an Amazon S3 on Outposts bucket's tags. To delete an S3 bucket
        /// tags, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketTagging.html">DeleteBucketTagging</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Deletes the tags from the Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <code>PutBucketTagging</code>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others. 
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html#API_control_DeleteBucketTagging_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html">GetBucketTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html">PutBucketTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteBucketTagging">REST API Reference for DeleteBucketTagging Operation</seealso>
        public virtual Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBucketTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJobTagging


        /// <summary>
        /// Removes the entire tag set from the specified S3 Batch Operations job. To use this
        /// operation, you must have permission to perform the <code>s3:DeleteJobTagging</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
        /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutJobTagging.html">PutJobTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteJobTagging">REST API Reference for DeleteJobTagging Operation</seealso>
        public virtual DeleteJobTaggingResponse DeleteJobTagging(DeleteJobTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteJobTaggingResponse>(request, options);
        }


        /// <summary>
        /// Removes the entire tag set from the specified S3 Batch Operations job. To use this
        /// operation, you must have permission to perform the <code>s3:DeleteJobTagging</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
        /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutJobTagging.html">PutJobTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteJobTagging">REST API Reference for DeleteJobTagging Operation</seealso>
        public virtual Task<DeleteJobTaggingResponse> DeleteJobTaggingAsync(DeleteJobTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobTaggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteJobTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMultiRegionAccessPoint


        /// <summary>
        /// Deletes a Multi-Region Access Point. This action does not delete the buckets associated
        /// with the Multi-Region Access Point, only the Multi-Region Access Point itself.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This request is asynchronous, meaning that you might receive a response before the
        /// command has completed. When this request provides a response, it provides a token
        /// that you can use to monitor the status of the request with <code>DescribeMultiRegionAccessPointOperation</code>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionAccessPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteMultiRegionAccessPoint">REST API Reference for DeleteMultiRegionAccessPoint Operation</seealso>
        public virtual DeleteMultiRegionAccessPointResponse DeleteMultiRegionAccessPoint(DeleteMultiRegionAccessPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMultiRegionAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMultiRegionAccessPointResponseUnmarshaller.Instance;

            return Invoke<DeleteMultiRegionAccessPointResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Multi-Region Access Point. This action does not delete the buckets associated
        /// with the Multi-Region Access Point, only the Multi-Region Access Point itself.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This request is asynchronous, meaning that you might receive a response before the
        /// command has completed. When this request provides a response, it provides a token
        /// that you can use to monitor the status of the request with <code>DescribeMultiRegionAccessPointOperation</code>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>DeleteMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiRegionAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteMultiRegionAccessPoint">REST API Reference for DeleteMultiRegionAccessPoint Operation</seealso>
        public virtual Task<DeleteMultiRegionAccessPointResponse> DeleteMultiRegionAccessPointAsync(DeleteMultiRegionAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMultiRegionAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMultiRegionAccessPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMultiRegionAccessPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePublicAccessBlock


        /// <summary>
        /// Removes the <code>PublicAccessBlock</code> configuration for an Amazon Web Services
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
        /// Using Amazon S3 block public access</a>.
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetPublicAccessBlock.html">GetPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutPublicAccessBlock.html">PutPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the DeletePublicAccessBlock service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeletePublicAccessBlock">REST API Reference for DeletePublicAccessBlock Operation</seealso>
        public virtual DeletePublicAccessBlockResponse DeletePublicAccessBlock(DeletePublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<DeletePublicAccessBlockResponse>(request, options);
        }


        /// <summary>
        /// Removes the <code>PublicAccessBlock</code> configuration for an Amazon Web Services
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
        /// Using Amazon S3 block public access</a>.
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetPublicAccessBlock.html">GetPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutPublicAccessBlock.html">PutPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePublicAccessBlock service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeletePublicAccessBlock">REST API Reference for DeletePublicAccessBlock Operation</seealso>
        public virtual Task<DeletePublicAccessBlockResponse> DeletePublicAccessBlockAsync(DeletePublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicAccessBlockResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePublicAccessBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStorageLensConfiguration


        /// <summary>
        /// Deletes the Amazon S3 Storage Lens configuration. For more information about S3 Storage
        /// Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:DeleteStorageLensConfiguration</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfiguration">REST API Reference for DeleteStorageLensConfiguration Operation</seealso>
        public virtual DeleteStorageLensConfigurationResponse DeleteStorageLensConfiguration(DeleteStorageLensConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageLensConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageLensConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteStorageLensConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the Amazon S3 Storage Lens configuration. For more information about S3 Storage
        /// Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:DeleteStorageLensConfiguration</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfiguration">REST API Reference for DeleteStorageLensConfiguration Operation</seealso>
        public virtual Task<DeleteStorageLensConfigurationResponse> DeleteStorageLensConfigurationAsync(DeleteStorageLensConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageLensConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageLensConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteStorageLensConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStorageLensConfigurationTagging


        /// <summary>
        /// Deletes the Amazon S3 Storage Lens configuration tags. For more information about
        /// S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:DeleteStorageLensConfigurationTagging</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensConfigurationTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfigurationTagging">REST API Reference for DeleteStorageLensConfigurationTagging Operation</seealso>
        public virtual DeleteStorageLensConfigurationTaggingResponse DeleteStorageLensConfigurationTagging(DeleteStorageLensConfigurationTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageLensConfigurationTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageLensConfigurationTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteStorageLensConfigurationTaggingResponse>(request, options);
        }


        /// <summary>
        /// Deletes the Amazon S3 Storage Lens configuration tags. For more information about
        /// S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:DeleteStorageLensConfigurationTagging</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageLensConfigurationTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DeleteStorageLensConfigurationTagging">REST API Reference for DeleteStorageLensConfigurationTagging Operation</seealso>
        public virtual Task<DeleteStorageLensConfigurationTaggingResponse> DeleteStorageLensConfigurationTaggingAsync(DeleteStorageLensConfigurationTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageLensConfigurationTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageLensConfigurationTaggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteStorageLensConfigurationTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// Retrieves the configuration parameters and status for a Batch Operations job. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        public virtual DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;

            return Invoke<DescribeJobResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the configuration parameters and status for a Batch Operations job. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        public virtual Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMultiRegionAccessPointOperation


        /// <summary>
        /// Retrieves the status of an asynchronous request to manage a Multi-Region Access Point.
        /// For more information about managing Multi-Region Access Points and how asynchronous
        /// requests work, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiRegionAccessPointOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeMultiRegionAccessPointOperation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeMultiRegionAccessPointOperation">REST API Reference for DescribeMultiRegionAccessPointOperation Operation</seealso>
        public virtual DescribeMultiRegionAccessPointOperationResponse DescribeMultiRegionAccessPointOperation(DescribeMultiRegionAccessPointOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMultiRegionAccessPointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMultiRegionAccessPointOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeMultiRegionAccessPointOperationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the status of an asynchronous request to manage a Multi-Region Access Point.
        /// For more information about managing Multi-Region Access Points and how asynchronous
        /// requests work, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiRegionAccessPointOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMultiRegionAccessPointOperation service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/DescribeMultiRegionAccessPointOperation">REST API Reference for DescribeMultiRegionAccessPointOperation Operation</seealso>
        public virtual Task<DescribeMultiRegionAccessPointOperationResponse> DescribeMultiRegionAccessPointOperationAsync(DescribeMultiRegionAccessPointOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMultiRegionAccessPointOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMultiRegionAccessPointOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMultiRegionAccessPointOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessPoint


        /// <summary>
        /// Returns configuration information about the specified access point.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html#API_control_GetAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPoint service method.</param>
        /// 
        /// <returns>The response from the GetAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPoint">REST API Reference for GetAccessPoint Operation</seealso>
        public virtual GetAccessPointResponse GetAccessPoint(GetAccessPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointResponseUnmarshaller.Instance;

            return Invoke<GetAccessPointResponse>(request, options);
        }


        /// <summary>
        /// Returns configuration information about the specified access point.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html#API_control_GetAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPoint">REST API Reference for GetAccessPoint Operation</seealso>
        public virtual Task<GetAccessPointResponse> GetAccessPointAsync(GetAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessPointConfigurationForObjectLambda


        /// <summary>
        /// Returns configuration for an Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPointConfigurationForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointConfigurationForObjectLambda.html">PutAccessPointConfigurationForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointConfigurationForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointConfigurationForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointConfigurationForObjectLambda">REST API Reference for GetAccessPointConfigurationForObjectLambda Operation</seealso>
        public virtual GetAccessPointConfigurationForObjectLambdaResponse GetAccessPointConfigurationForObjectLambda(GetAccessPointConfigurationForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointConfigurationForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointConfigurationForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<GetAccessPointConfigurationForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Returns configuration for an Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPointConfigurationForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointConfigurationForObjectLambda.html">PutAccessPointConfigurationForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointConfigurationForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointConfigurationForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointConfigurationForObjectLambda">REST API Reference for GetAccessPointConfigurationForObjectLambda Operation</seealso>
        public virtual Task<GetAccessPointConfigurationForObjectLambdaResponse> GetAccessPointConfigurationForObjectLambdaAsync(GetAccessPointConfigurationForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointConfigurationForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointConfigurationForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessPointConfigurationForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessPointForObjectLambda


        /// <summary>
        /// Returns configuration information about the specified Object Lambda Access Point
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPointForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPointForObjectLambda.html">CreateAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointForObjectLambda.html">DeleteAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForObjectLambda.html">ListAccessPointsForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointForObjectLambda">REST API Reference for GetAccessPointForObjectLambda Operation</seealso>
        public virtual GetAccessPointForObjectLambdaResponse GetAccessPointForObjectLambda(GetAccessPointForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<GetAccessPointForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Returns configuration information about the specified Object Lambda Access Point
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPointForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPointForObjectLambda.html">CreateAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointForObjectLambda.html">DeleteAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForObjectLambda.html">ListAccessPointsForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointForObjectLambda">REST API Reference for GetAccessPointForObjectLambda Operation</seealso>
        public virtual Task<GetAccessPointForObjectLambdaResponse> GetAccessPointForObjectLambdaAsync(GetAccessPointForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessPointForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessPointPolicy


        /// <summary>
        /// Returns the access point policy associated with the specified access point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicy.html">DeleteAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicy">REST API Reference for GetAccessPointPolicy Operation</seealso>
        public virtual GetAccessPointPolicyResponse GetAccessPointPolicy(GetAccessPointPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAccessPointPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the access point policy associated with the specified access point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicy.html">DeleteAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicy">REST API Reference for GetAccessPointPolicy Operation</seealso>
        public virtual Task<GetAccessPointPolicyResponse> GetAccessPointPolicyAsync(GetAccessPointPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessPointPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessPointPolicyForObjectLambda


        /// <summary>
        /// Returns the resource policy for an Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPointPolicyForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicyForObjectLambda.html">DeleteAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicyForObjectLambda.html">PutAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyForObjectLambda">REST API Reference for GetAccessPointPolicyForObjectLambda Operation</seealso>
        public virtual GetAccessPointPolicyForObjectLambdaResponse GetAccessPointPolicyForObjectLambda(GetAccessPointPolicyForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointPolicyForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointPolicyForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<GetAccessPointPolicyForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Returns the resource policy for an Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>GetAccessPointPolicyForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicyForObjectLambda.html">DeleteAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicyForObjectLambda.html">PutAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyForObjectLambda">REST API Reference for GetAccessPointPolicyForObjectLambda Operation</seealso>
        public virtual Task<GetAccessPointPolicyForObjectLambdaResponse> GetAccessPointPolicyForObjectLambdaAsync(GetAccessPointPolicyForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointPolicyForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointPolicyForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessPointPolicyForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessPointPolicyStatus


        /// <summary>
        /// Indicates whether the specified access point currently has a policy that allows public
        /// access. For more information about public access through access points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points.html">Managing
        /// Data Access with Amazon S3 access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatus service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyStatus service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatus">REST API Reference for GetAccessPointPolicyStatus Operation</seealso>
        public virtual GetAccessPointPolicyStatusResponse GetAccessPointPolicyStatus(GetAccessPointPolicyStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointPolicyStatusResponseUnmarshaller.Instance;

            return Invoke<GetAccessPointPolicyStatusResponse>(request, options);
        }


        /// <summary>
        /// Indicates whether the specified access point currently has a policy that allows public
        /// access. For more information about public access through access points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points.html">Managing
        /// Data Access with Amazon S3 access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyStatus service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatus">REST API Reference for GetAccessPointPolicyStatus Operation</seealso>
        public virtual Task<GetAccessPointPolicyStatusResponse> GetAccessPointPolicyStatusAsync(GetAccessPointPolicyStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointPolicyStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessPointPolicyStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccessPointPolicyStatusForObjectLambda


        /// <summary>
        /// Returns the status of the resource policy associated with an Object Lambda Access
        /// Point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatusForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyStatusForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatusForObjectLambda">REST API Reference for GetAccessPointPolicyStatusForObjectLambda Operation</seealso>
        public virtual GetAccessPointPolicyStatusForObjectLambdaResponse GetAccessPointPolicyStatusForObjectLambda(GetAccessPointPolicyStatusForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointPolicyStatusForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointPolicyStatusForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<GetAccessPointPolicyStatusForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Returns the status of the resource policy associated with an Object Lambda Access
        /// Point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatusForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyStatusForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetAccessPointPolicyStatusForObjectLambda">REST API Reference for GetAccessPointPolicyStatusForObjectLambda Operation</seealso>
        public virtual Task<GetAccessPointPolicyStatusForObjectLambdaResponse> GetAccessPointPolicyStatusForObjectLambdaAsync(GetAccessPointPolicyStatusForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessPointPolicyStatusForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessPointPolicyStatusForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccessPointPolicyStatusForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucket


        /// <summary>
        /// Gets an Amazon S3 on Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">
        /// Using Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you are using an identity other than the root user of the Amazon Web Services account
        /// that owns the Outposts bucket, the calling identity must have the <code>s3-outposts:GetBucket</code>
        /// permissions on the specified Outposts bucket and belong to the Outposts bucket owner's
        /// account in order to use this action. Only users from Outposts bucket owner account
        /// with the right permissions can perform actions on an Outposts bucket. 
        /// </para>
        ///  
        /// <para>
        ///  If you don't have <code>s3-outposts:GetBucket</code> permissions or you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>403
        /// Access Denied</code> error.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetBucket</code> for Amazon S3 on Outposts:
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html#API_control_GetBucket_Examples">Examples</a>
        /// section.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html">CreateBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html">DeleteBucket</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucket service method.</param>
        /// 
        /// <returns>The response from the GetBucket service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucket">REST API Reference for GetBucket Operation</seealso>
        public virtual GetBucketResponse GetBucket(GetBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketResponseUnmarshaller.Instance;

            return Invoke<GetBucketResponse>(request, options);
        }


        /// <summary>
        /// Gets an Amazon S3 on Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">
        /// Using Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you are using an identity other than the root user of the Amazon Web Services account
        /// that owns the Outposts bucket, the calling identity must have the <code>s3-outposts:GetBucket</code>
        /// permissions on the specified Outposts bucket and belong to the Outposts bucket owner's
        /// account in order to use this action. Only users from Outposts bucket owner account
        /// with the right permissions can perform actions on an Outposts bucket. 
        /// </para>
        ///  
        /// <para>
        ///  If you don't have <code>s3-outposts:GetBucket</code> permissions or you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>403
        /// Access Denied</code> error.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetBucket</code> for Amazon S3 on Outposts:
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html#API_control_GetBucket_Examples">Examples</a>
        /// section.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html">CreateBucket</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html">DeleteBucket</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucket service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucket">REST API Reference for GetBucket Operation</seealso>
        public virtual Task<GetBucketResponse> GetBucketAsync(GetBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketLifecycleConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This action gets an Amazon S3 on Outposts bucket's lifecycle configuration. To get
        /// an S3 bucket's lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the lifecycle configuration information set on the Outposts bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> and for information about lifecycle configuration, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">
        /// Object Lifecycle Management</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3-outposts:GetLifecycleConfiguration</code>
        /// action. The Outposts bucket owner has this permission, by default. The bucket owner
        /// can grant this permission to others. For more information about permissions, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html#API_control_GetBucketLifecycleConfiguration_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetBucketLifecycleConfiguration</code> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>NoSuchLifecycleConfiguration</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The lifecycle configuration does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SOAP Fault Code Prefix: Client
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following actions are related to <code>GetBucketLifecycleConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketLifecycleConfiguration.html">DeleteBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketLifecycleConfiguration">REST API Reference for GetBucketLifecycleConfiguration Operation</seealso>
        public virtual GetBucketLifecycleConfigurationResponse GetBucketLifecycleConfiguration(GetBucketLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action gets an Amazon S3 on Outposts bucket's lifecycle configuration. To get
        /// an S3 bucket's lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the lifecycle configuration information set on the Outposts bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> and for information about lifecycle configuration, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">
        /// Object Lifecycle Management</a> in <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3-outposts:GetLifecycleConfiguration</code>
        /// action. The Outposts bucket owner has this permission, by default. The bucket owner
        /// can grant this permission to others. For more information about permissions, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html#API_control_GetBucketLifecycleConfiguration_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetBucketLifecycleConfiguration</code> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>NoSuchLifecycleConfiguration</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The lifecycle configuration does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SOAP Fault Code Prefix: Client
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following actions are related to <code>GetBucketLifecycleConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketLifecycleConfiguration.html">DeleteBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketLifecycleConfiguration">REST API Reference for GetBucketLifecycleConfiguration Operation</seealso>
        public virtual Task<GetBucketLifecycleConfigurationResponse> GetBucketLifecycleConfigurationAsync(GetBucketLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLifecycleConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBucketLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This action gets a bucket policy for an Amazon S3 on Outposts bucket. To get a policy
        /// for an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketPolicy.html">GetBucketPolicy</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the policy of a specified Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are using an identity other than the root user of the Amazon Web Services account
        /// that owns the bucket, the calling identity must have the <code>GetBucketPolicy</code>
        /// permissions on the specified bucket and belong to the bucket owner's account in order
        /// to use this action.
        /// </para>
        ///  
        /// <para>
        /// Only users from Outposts bucket owner account with the right permissions can perform
        /// actions on an Outposts bucket. If you don't have <code>s3-outposts:GetBucketPolicy</code>
        /// permissions or you're not using an identity that belongs to the bucket owner's account,
        /// Amazon S3 returns a <code>403 Access Denied</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the Amazon Web Services account that owns
        /// a bucket can always use this action, even if the policy explicitly denies the root
        /// user the ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html#API_control_GetBucketPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html">PutBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketPolicy">REST API Reference for GetBucketPolicy Operation</seealso>
        public virtual GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action gets a bucket policy for an Amazon S3 on Outposts bucket. To get a policy
        /// for an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketPolicy.html">GetBucketPolicy</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the policy of a specified Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are using an identity other than the root user of the Amazon Web Services account
        /// that owns the bucket, the calling identity must have the <code>GetBucketPolicy</code>
        /// permissions on the specified bucket and belong to the bucket owner's account in order
        /// to use this action.
        /// </para>
        ///  
        /// <para>
        /// Only users from Outposts bucket owner account with the right permissions can perform
        /// actions on an Outposts bucket. If you don't have <code>s3-outposts:GetBucketPolicy</code>
        /// permissions or you're not using an identity that belongs to the bucket owner's account,
        /// Amazon S3 returns a <code>403 Access Denied</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the Amazon Web Services account that owns
        /// a bucket can always use this action, even if the policy explicitly denies the root
        /// user the ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html#API_control_GetBucketPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html">PutBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketPolicy">REST API Reference for GetBucketPolicy Operation</seealso>
        public virtual Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBucketPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketTagging


        /// <summary>
        /// <note> 
        /// <para>
        /// This action gets an Amazon S3 on Outposts bucket's tags. To get an S3 bucket tags,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketTagging.html">GetBucketTagging</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the tag set associated with the Outposts bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <code>GetBucketTagging</code>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetBucketTagging</code> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>NoSuchTagSetError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: There is no tag set associated with the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html#API_control_GetBucketTagging_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html">PutBucketTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html">DeleteBucketTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging service method.</param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketTagging">REST API Reference for GetBucketTagging Operation</seealso>
        public virtual GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketTaggingResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action gets an Amazon S3 on Outposts bucket's tags. To get an S3 bucket tags,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketTagging.html">GetBucketTagging</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the tag set associated with the Outposts bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use this action, you must have permission to perform the <code>GetBucketTagging</code>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetBucketTagging</code> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>NoSuchTagSetError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: There is no tag set associated with the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html#API_control_GetBucketTagging_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html">PutBucketTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html">DeleteBucketTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetBucketTagging">REST API Reference for GetBucketTagging Operation</seealso>
        public virtual Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBucketTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJobTagging


        /// <summary>
        /// Returns the tags on an S3 Batch Operations job. To use this operation, you must have
        /// permission to perform the <code>s3:GetJobTagging</code> action. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
        /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutJobTagging.html">PutJobTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobTagging service method.</param>
        /// 
        /// <returns>The response from the GetJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetJobTagging">REST API Reference for GetJobTagging Operation</seealso>
        public virtual GetJobTaggingResponse GetJobTagging(GetJobTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobTaggingResponseUnmarshaller.Instance;

            return Invoke<GetJobTaggingResponse>(request, options);
        }


        /// <summary>
        /// Returns the tags on an S3 Batch Operations job. To use this operation, you must have
        /// permission to perform the <code>s3:GetJobTagging</code> action. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
        /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutJobTagging.html">PutJobTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetJobTagging">REST API Reference for GetJobTagging Operation</seealso>
        public virtual Task<GetJobTaggingResponse> GetJobTaggingAsync(GetJobTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobTaggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMultiRegionAccessPoint


        /// <summary>
        /// Returns configuration information about the specified Multi-Region Access Point.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPoint service method.</param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPoint">REST API Reference for GetMultiRegionAccessPoint Operation</seealso>
        public virtual GetMultiRegionAccessPointResponse GetMultiRegionAccessPoint(GetMultiRegionAccessPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMultiRegionAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMultiRegionAccessPointResponseUnmarshaller.Instance;

            return Invoke<GetMultiRegionAccessPointResponse>(request, options);
        }


        /// <summary>
        /// Returns configuration information about the specified Multi-Region Access Point.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListMultiRegionAccessPoints.html">ListMultiRegionAccessPoints</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPoint service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPoint">REST API Reference for GetMultiRegionAccessPoint Operation</seealso>
        public virtual Task<GetMultiRegionAccessPointResponse> GetMultiRegionAccessPointAsync(GetMultiRegionAccessPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMultiRegionAccessPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMultiRegionAccessPointResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMultiRegionAccessPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMultiRegionAccessPointPolicy


        /// <summary>
        /// Returns the access control policy of the specified Multi-Region Access Point.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetMultiRegionAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicyStatus.html">GetMultiRegionAccessPointPolicyStatus</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutMultiRegionAccessPointPolicy.html">PutMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicy">REST API Reference for GetMultiRegionAccessPointPolicy Operation</seealso>
        public virtual GetMultiRegionAccessPointPolicyResponse GetMultiRegionAccessPointPolicy(GetMultiRegionAccessPointPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMultiRegionAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMultiRegionAccessPointPolicyResponseUnmarshaller.Instance;

            return Invoke<GetMultiRegionAccessPointPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the access control policy of the specified Multi-Region Access Point.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetMultiRegionAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicyStatus.html">GetMultiRegionAccessPointPolicyStatus</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutMultiRegionAccessPointPolicy.html">PutMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicy">REST API Reference for GetMultiRegionAccessPointPolicy Operation</seealso>
        public virtual Task<GetMultiRegionAccessPointPolicyResponse> GetMultiRegionAccessPointPolicyAsync(GetMultiRegionAccessPointPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMultiRegionAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMultiRegionAccessPointPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMultiRegionAccessPointPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMultiRegionAccessPointPolicyStatus


        /// <summary>
        /// Indicates whether the specified Multi-Region Access Point has an access control policy
        /// that allows public access.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetMultiRegionAccessPointPolicyStatus</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicy.html">GetMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutMultiRegionAccessPointPolicy.html">PutMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointPolicyStatus service method.</param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointPolicyStatus service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicyStatus">REST API Reference for GetMultiRegionAccessPointPolicyStatus Operation</seealso>
        public virtual GetMultiRegionAccessPointPolicyStatusResponse GetMultiRegionAccessPointPolicyStatus(GetMultiRegionAccessPointPolicyStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMultiRegionAccessPointPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMultiRegionAccessPointPolicyStatusResponseUnmarshaller.Instance;

            return Invoke<GetMultiRegionAccessPointPolicyStatusResponse>(request, options);
        }


        /// <summary>
        /// Indicates whether the specified Multi-Region Access Point has an access control policy
        /// that allows public access.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>GetMultiRegionAccessPointPolicyStatus</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicy.html">GetMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutMultiRegionAccessPointPolicy.html">PutMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMultiRegionAccessPointPolicyStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMultiRegionAccessPointPolicyStatus service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetMultiRegionAccessPointPolicyStatus">REST API Reference for GetMultiRegionAccessPointPolicyStatus Operation</seealso>
        public virtual Task<GetMultiRegionAccessPointPolicyStatusResponse> GetMultiRegionAccessPointPolicyStatusAsync(GetMultiRegionAccessPointPolicyStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMultiRegionAccessPointPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMultiRegionAccessPointPolicyStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMultiRegionAccessPointPolicyStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPublicAccessBlock


        /// <summary>
        /// Retrieves the <code>PublicAccessBlock</code> configuration for an Amazon Web Services
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
        /// Using Amazon S3 block public access</a>.
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeletePublicAccessBlock.html">DeletePublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutPublicAccessBlock.html">PutPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the GetPublicAccessBlock service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.NoSuchPublicAccessBlockConfigurationException">
        /// Amazon S3 throws this exception if you make a <code>GetPublicAccessBlock</code> request
        /// against an account that doesn't have a <code>PublicAccessBlockConfiguration</code>
        /// set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetPublicAccessBlock">REST API Reference for GetPublicAccessBlock Operation</seealso>
        public virtual GetPublicAccessBlockResponse GetPublicAccessBlock(GetPublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<GetPublicAccessBlockResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the <code>PublicAccessBlock</code> configuration for an Amazon Web Services
        /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
        /// Using Amazon S3 block public access</a>.
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeletePublicAccessBlock.html">DeletePublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutPublicAccessBlock.html">PutPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPublicAccessBlock service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.NoSuchPublicAccessBlockConfigurationException">
        /// Amazon S3 throws this exception if you make a <code>GetPublicAccessBlock</code> request
        /// against an account that doesn't have a <code>PublicAccessBlockConfiguration</code>
        /// set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetPublicAccessBlock">REST API Reference for GetPublicAccessBlock Operation</seealso>
        public virtual Task<GetPublicAccessBlockResponse> GetPublicAccessBlockAsync(GetPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPublicAccessBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStorageLensConfiguration


        /// <summary>
        /// Gets the Amazon S3 Storage Lens configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:GetStorageLensConfiguration</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfiguration">REST API Reference for GetStorageLensConfiguration Operation</seealso>
        public virtual GetStorageLensConfigurationResponse GetStorageLensConfiguration(GetStorageLensConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStorageLensConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageLensConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetStorageLensConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Gets the Amazon S3 Storage Lens configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:GetStorageLensConfiguration</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfiguration">REST API Reference for GetStorageLensConfiguration Operation</seealso>
        public virtual Task<GetStorageLensConfigurationResponse> GetStorageLensConfigurationAsync(GetStorageLensConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStorageLensConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageLensConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStorageLensConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStorageLensConfigurationTagging


        /// <summary>
        /// Gets the tags of Amazon S3 Storage Lens configuration. For more information about
        /// S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:GetStorageLensConfigurationTagging</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensConfigurationTagging service method.</param>
        /// 
        /// <returns>The response from the GetStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfigurationTagging">REST API Reference for GetStorageLensConfigurationTagging Operation</seealso>
        public virtual GetStorageLensConfigurationTaggingResponse GetStorageLensConfigurationTagging(GetStorageLensConfigurationTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStorageLensConfigurationTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageLensConfigurationTaggingResponseUnmarshaller.Instance;

            return Invoke<GetStorageLensConfigurationTaggingResponse>(request, options);
        }


        /// <summary>
        /// Gets the tags of Amazon S3 Storage Lens configuration. For more information about
        /// S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:GetStorageLensConfigurationTagging</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageLensConfigurationTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/GetStorageLensConfigurationTagging">REST API Reference for GetStorageLensConfigurationTagging Operation</seealso>
        public virtual Task<GetStorageLensConfigurationTaggingResponse> GetStorageLensConfigurationTaggingAsync(GetStorageLensConfigurationTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStorageLensConfigurationTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageLensConfigurationTaggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStorageLensConfigurationTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessPoints


        /// <summary>
        /// Returns a list of the access points currently associated with the specified bucket.
        /// You can retrieve up to 1000 access points per call. If the specified bucket has more
        /// than 1,000 access points (or the number specified in <code>maxResults</code>, whichever
        /// is less), the response will include a continuation token that you can use to list
        /// the additional access points.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html#API_control_GetAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>ListAccessPoints</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPoints service method.</param>
        /// 
        /// <returns>The response from the ListAccessPoints service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPoints">REST API Reference for ListAccessPoints Operation</seealso>
        public virtual ListAccessPointsResponse ListAccessPoints(ListAccessPointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPointsResponseUnmarshaller.Instance;

            return Invoke<ListAccessPointsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the access points currently associated with the specified bucket.
        /// You can retrieve up to 1000 access points per call. If the specified bucket has more
        /// than 1,000 access points (or the number specified in <code>maxResults</code>, whichever
        /// is less), the response will include a continuation token that you can use to list
        /// the additional access points.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html#API_control_GetAccessPoint_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>ListAccessPoints</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPoints service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPoints">REST API Reference for ListAccessPoints Operation</seealso>
        public virtual Task<ListAccessPointsResponse> ListAccessPointsAsync(ListAccessPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessPointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAccessPointsForObjectLambda


        /// <summary>
        /// Returns a list of the access points associated with the Object Lambda Access Point.
        /// You can retrieve up to 1000 access points per call. If there are more than 1,000 access
        /// points (or the number specified in <code>maxResults</code>, whichever is less), the
        /// response will include a continuation token that you can use to list the additional
        /// access points.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>ListAccessPointsForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPointForObjectLambda.html">CreateAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointForObjectLambda.html">DeleteAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointForObjectLambda.html">GetAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPointsForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the ListAccessPointsForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForObjectLambda">REST API Reference for ListAccessPointsForObjectLambda Operation</seealso>
        public virtual ListAccessPointsForObjectLambdaResponse ListAccessPointsForObjectLambda(ListAccessPointsForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPointsForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPointsForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<ListAccessPointsForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the access points associated with the Object Lambda Access Point.
        /// You can retrieve up to 1000 access points per call. If there are more than 1,000 access
        /// points (or the number specified in <code>maxResults</code>, whichever is less), the
        /// response will include a continuation token that you can use to list the additional
        /// access points.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>ListAccessPointsForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPointForObjectLambda.html">CreateAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointForObjectLambda.html">DeleteAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointForObjectLambda.html">GetAccessPointForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPointsForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPointsForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListAccessPointsForObjectLambda">REST API Reference for ListAccessPointsForObjectLambda Operation</seealso>
        public virtual Task<ListAccessPointsForObjectLambdaResponse> ListAccessPointsForObjectLambdaAsync(ListAccessPointsForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAccessPointsForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPointsForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAccessPointsForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists current S3 Batch Operations jobs and jobs that have ended within the last 30
        /// days for the Amazon Web Services account making the request. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///   <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InvalidNextTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }


        /// <summary>
        /// Lists current S3 Batch Operations jobs and jobs that have ended within the last 30
        /// days for the Amazon Web Services account making the request. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///   <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobPriority.html">UpdateJobPriority</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InvalidNextTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMultiRegionAccessPoints


        /// <summary>
        /// Returns a list of the Multi-Region Access Points currently associated with the specified
        /// Amazon Web Services account. Each call can return up to 100 Multi-Region Access Points,
        /// the maximum number of Multi-Region Access Points that can be associated with a single
        /// account.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>ListMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiRegionAccessPoints service method.</param>
        /// 
        /// <returns>The response from the ListMultiRegionAccessPoints service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListMultiRegionAccessPoints">REST API Reference for ListMultiRegionAccessPoints Operation</seealso>
        public virtual ListMultiRegionAccessPointsResponse ListMultiRegionAccessPoints(ListMultiRegionAccessPointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultiRegionAccessPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultiRegionAccessPointsResponseUnmarshaller.Instance;

            return Invoke<ListMultiRegionAccessPointsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the Multi-Region Access Points currently associated with the specified
        /// Amazon Web Services account. Each call can return up to 100 Multi-Region Access Points,
        /// the maximum number of Multi-Region Access Points that can be associated with a single
        /// account.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>ListMultiRegionAccessPoint</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeMultiRegionAccessPointOperation.html">DescribeMultiRegionAccessPointOperation</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPoint.html">GetMultiRegionAccessPoint</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiRegionAccessPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultiRegionAccessPoints service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListMultiRegionAccessPoints">REST API Reference for ListMultiRegionAccessPoints Operation</seealso>
        public virtual Task<ListMultiRegionAccessPointsResponse> ListMultiRegionAccessPointsAsync(ListMultiRegionAccessPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultiRegionAccessPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultiRegionAccessPointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMultiRegionAccessPointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRegionalBuckets


        /// <summary>
        /// Returns a list of all Outposts buckets in an Outpost that are owned by the authenticated
        /// sender of the request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and <code>x-amz-outpost-id</code> in your request,
        /// see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListRegionalBuckets.html#API_control_ListRegionalBuckets_Examples">Examples</a>
        /// section.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegionalBuckets service method.</param>
        /// 
        /// <returns>The response from the ListRegionalBuckets service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListRegionalBuckets">REST API Reference for ListRegionalBuckets Operation</seealso>
        public virtual ListRegionalBucketsResponse ListRegionalBuckets(ListRegionalBucketsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegionalBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegionalBucketsResponseUnmarshaller.Instance;

            return Invoke<ListRegionalBucketsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all Outposts buckets in an Outpost that are owned by the authenticated
        /// sender of the request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
        /// Outposts endpoint hostname prefix and <code>x-amz-outpost-id</code> in your request,
        /// see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListRegionalBuckets.html#API_control_ListRegionalBuckets_Examples">Examples</a>
        /// section.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegionalBuckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegionalBuckets service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListRegionalBuckets">REST API Reference for ListRegionalBuckets Operation</seealso>
        public virtual Task<ListRegionalBucketsResponse> ListRegionalBucketsAsync(ListRegionalBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRegionalBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegionalBucketsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRegionalBucketsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStorageLensConfigurations


        /// <summary>
        /// Gets a list of Amazon S3 Storage Lens configurations. For more information about S3
        /// Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:ListStorageLensConfigurations</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageLensConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListStorageLensConfigurations service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensConfigurations">REST API Reference for ListStorageLensConfigurations Operation</seealso>
        public virtual ListStorageLensConfigurationsResponse ListStorageLensConfigurations(ListStorageLensConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStorageLensConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageLensConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListStorageLensConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of Amazon S3 Storage Lens configurations. For more information about S3
        /// Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:ListStorageLensConfigurations</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageLensConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStorageLensConfigurations service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/ListStorageLensConfigurations">REST API Reference for ListStorageLensConfigurations Operation</seealso>
        public virtual Task<ListStorageLensConfigurationsResponse> ListStorageLensConfigurationsAsync(ListStorageLensConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStorageLensConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageLensConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListStorageLensConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccessPointConfigurationForObjectLambda


        /// <summary>
        /// Replaces configuration for an Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>PutAccessPointConfigurationForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointConfigurationForObjectLambda.html">GetAccessPointConfigurationForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointConfigurationForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the PutAccessPointConfigurationForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointConfigurationForObjectLambda">REST API Reference for PutAccessPointConfigurationForObjectLambda Operation</seealso>
        public virtual PutAccessPointConfigurationForObjectLambdaResponse PutAccessPointConfigurationForObjectLambda(PutAccessPointConfigurationForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccessPointConfigurationForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccessPointConfigurationForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<PutAccessPointConfigurationForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Replaces configuration for an Object Lambda Access Point.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>PutAccessPointConfigurationForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointConfigurationForObjectLambda.html">GetAccessPointConfigurationForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointConfigurationForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccessPointConfigurationForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointConfigurationForObjectLambda">REST API Reference for PutAccessPointConfigurationForObjectLambda Operation</seealso>
        public virtual Task<PutAccessPointConfigurationForObjectLambdaResponse> PutAccessPointConfigurationForObjectLambdaAsync(PutAccessPointConfigurationForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccessPointConfigurationForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccessPointConfigurationForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAccessPointConfigurationForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccessPointPolicy


        /// <summary>
        /// Associates an access policy with the specified access point. Each access point can
        /// have only one policy, so a request made to this API replaces any existing policy associated
        /// with the specified access point.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html#API_control_PutAccessPointPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicy.html">GetAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicy.html">DeleteAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the PutAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicy">REST API Reference for PutAccessPointPolicy Operation</seealso>
        public virtual PutAccessPointPolicyResponse PutAccessPointPolicy(PutAccessPointPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccessPointPolicyResponseUnmarshaller.Instance;

            return Invoke<PutAccessPointPolicyResponse>(request, options);
        }


        /// <summary>
        /// Associates an access policy with the specified access point. Each access point can
        /// have only one policy, so a request made to this API replaces any existing policy associated
        /// with the specified access point.
        /// 
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html#API_control_PutAccessPointPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicy.html">GetAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicy.html">DeleteAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicy">REST API Reference for PutAccessPointPolicy Operation</seealso>
        public virtual Task<PutAccessPointPolicyResponse> PutAccessPointPolicyAsync(PutAccessPointPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccessPointPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAccessPointPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAccessPointPolicyForObjectLambda


        /// <summary>
        /// Creates or replaces resource policy for an Object Lambda Access Point. For an example
        /// policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/olap-create.html#olap-create-cli">Creating
        /// Object Lambda Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>PutAccessPointPolicyForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicyForObjectLambda.html">DeleteAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicyForObjectLambda.html">GetAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicyForObjectLambda service method.</param>
        /// 
        /// <returns>The response from the PutAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicyForObjectLambda">REST API Reference for PutAccessPointPolicyForObjectLambda Operation</seealso>
        public virtual PutAccessPointPolicyForObjectLambdaResponse PutAccessPointPolicyForObjectLambda(PutAccessPointPolicyForObjectLambdaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccessPointPolicyForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccessPointPolicyForObjectLambdaResponseUnmarshaller.Instance;

            return Invoke<PutAccessPointPolicyForObjectLambdaResponse>(request, options);
        }


        /// <summary>
        /// Creates or replaces resource policy for an Object Lambda Access Point. For an example
        /// policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/olap-create.html#olap-create-cli">Creating
        /// Object Lambda Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The following actions are related to <code>PutAccessPointPolicyForObjectLambda</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPointPolicyForObjectLambda.html">DeleteAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPointPolicyForObjectLambda.html">GetAccessPointPolicyForObjectLambda</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicyForObjectLambda service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccessPointPolicyForObjectLambda service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutAccessPointPolicyForObjectLambda">REST API Reference for PutAccessPointPolicyForObjectLambda Operation</seealso>
        public virtual Task<PutAccessPointPolicyForObjectLambdaResponse> PutAccessPointPolicyForObjectLambdaAsync(PutAccessPointPolicyForObjectLambdaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccessPointPolicyForObjectLambdaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccessPointPolicyForObjectLambdaResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutAccessPointPolicyForObjectLambdaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketLifecycleConfiguration


        /// <summary>
        /// <note> 
        /// <para>
        /// This action puts a lifecycle configuration to an Amazon S3 on Outposts bucket. To
        /// put a lifecycle configuration to an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a new lifecycle configuration for the S3 on Outposts bucket or replaces an
        /// existing lifecycle configuration. Outposts buckets only support lifecycle configurations
        /// that delete/expire objects after a certain period of time and abort incomplete multipart
        /// uploads.
        /// </para>
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html#API_control_PutBucketLifecycleConfiguration_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutBucketLifecycleConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketLifecycleConfiguration.html">DeleteBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLifecycleConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketLifecycleConfiguration">REST API Reference for PutBucketLifecycleConfiguration Operation</seealso>
        public virtual PutBucketLifecycleConfigurationResponse PutBucketLifecycleConfiguration(PutBucketLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action puts a lifecycle configuration to an Amazon S3 on Outposts bucket. To
        /// put a lifecycle configuration to an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates a new lifecycle configuration for the S3 on Outposts bucket or replaces an
        /// existing lifecycle configuration. Outposts buckets only support lifecycle configurations
        /// that delete/expire objects after a certain period of time and abort incomplete multipart
        /// uploads.
        /// </para>
        ///   
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketLifecycleConfiguration.html#API_control_PutBucketLifecycleConfiguration_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutBucketLifecycleConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketLifecycleConfiguration.html">GetBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketLifecycleConfiguration.html">DeleteBucketLifecycleConfiguration</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketLifecycleConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketLifecycleConfiguration">REST API Reference for PutBucketLifecycleConfiguration Operation</seealso>
        public virtual Task<PutBucketLifecycleConfigurationResponse> PutBucketLifecycleConfigurationAsync(PutBucketLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketLifecycleConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutBucketLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketPolicy


        /// <summary>
        /// <note> 
        /// <para>
        /// This action puts a bucket policy to an Amazon S3 on Outposts bucket. To put a policy
        /// on an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketPolicy.html">PutBucketPolicy</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Applies an Amazon S3 bucket policy to an Outposts bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are using an identity other than the root user of the Amazon Web Services account
        /// that owns the Outposts bucket, the calling identity must have the <code>PutBucketPolicy</code>
        /// permissions on the specified Outposts bucket and belong to the bucket owner's account
        /// in order to use this action.
        /// </para>
        ///  
        /// <para>
        /// If you don't have <code>PutBucketPolicy</code> permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        ///  As a security precaution, the root user of the Amazon Web Services account that owns
        /// a bucket can always use this action, even if the policy explicitly denies the root
        /// user the ability to perform this action. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html#API_control_PutBucketPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html">GetBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketPolicy">REST API Reference for PutBucketPolicy Operation</seealso>
        public virtual PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBucketPolicyResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action puts a bucket policy to an Amazon S3 on Outposts bucket. To put a policy
        /// on an S3 bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketPolicy.html">PutBucketPolicy</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Applies an Amazon S3 bucket policy to an Outposts bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are using an identity other than the root user of the Amazon Web Services account
        /// that owns the Outposts bucket, the calling identity must have the <code>PutBucketPolicy</code>
        /// permissions on the specified Outposts bucket and belong to the bucket owner's account
        /// in order to use this action.
        /// </para>
        ///  
        /// <para>
        /// If you don't have <code>PutBucketPolicy</code> permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        ///  As a security precaution, the root user of the Amazon Web Services account that owns
        /// a bucket can always use this action, even if the policy explicitly denies the root
        /// user the ability to perform this action. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketPolicy.html#API_control_PutBucketPolicy_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketPolicy.html">GetBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketPolicy.html">DeleteBucketPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketPolicy">REST API Reference for PutBucketPolicy Operation</seealso>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutBucketPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketTagging


        /// <summary>
        /// <note> 
        /// <para>
        /// This action puts tags on an Amazon S3 on Outposts bucket. To put tags on an S3 bucket,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketTagging.html">PutBucketTagging</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Sets the tags for an S3 on Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use tags to organize your Amazon Web Services bill to reflect your own cost structure.
        /// To do this, sign up to get your Amazon Web Services account bill with tag key values
        /// included. Then, to see the cost of combined resources, organize your billing information
        /// according to resources with the same tag key values. For example, you can tag several
        /// resources with a specific application name, and then organize your billing information
        /// to see the total cost of that application across several services. For more information,
        /// see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Cost
        /// allocation and tagging</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Within a bucket, if you add a tag that has the same key as an existing tag, the new
        /// value overwrites the old value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CostAllocTagging.html">
        /// Using cost allocation in Amazon S3 bucket tags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this action, you must have permissions to perform the <code>s3-outposts:PutBucketTagging</code>
        /// action. The Outposts bucket owner has this permission by default and can grant this
        /// permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">
        /// Permissions Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
        /// access permissions to your Amazon S3 resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>PutBucketTagging</code> has the following special errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>InvalidTagError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The tag provided was not a valid tag. This error can occur if the tag
        /// did not pass input validation. For information about tag restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">
        /// User-Defined Tag Restrictions</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/aws-tag-restrictions.html">
        /// Amazon Web Services-Generated Cost Allocation Tag Restrictions</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>MalformedXMLError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The XML provided does not match the schema.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>OperationAbortedError </code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: A conflicting conditional action is currently in progress against this
        /// resource. Try again.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>InternalError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The service was unable to apply the provided tag to the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html#API_control_PutBucketTagging_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html">GetBucketTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html">DeleteBucketTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging service method.</param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketTagging">REST API Reference for PutBucketTagging Operation</seealso>
        public virtual PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketTaggingResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This action puts tags on an Amazon S3 on Outposts bucket. To put tags on an S3 bucket,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketTagging.html">PutBucketTagging</a>
        /// in the <i>Amazon S3 API Reference</i>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// Sets the tags for an S3 on Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use tags to organize your Amazon Web Services bill to reflect your own cost structure.
        /// To do this, sign up to get your Amazon Web Services account bill with tag key values
        /// included. Then, to see the cost of combined resources, organize your billing information
        /// according to resources with the same tag key values. For example, you can tag several
        /// resources with a specific application name, and then organize your billing information
        /// to see the total cost of that application across several services. For more information,
        /// see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Cost
        /// allocation and tagging</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Within a bucket, if you add a tag that has the same key as an existing tag, the new
        /// value overwrites the old value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CostAllocTagging.html">
        /// Using cost allocation in Amazon S3 bucket tags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this action, you must have permissions to perform the <code>s3-outposts:PutBucketTagging</code>
        /// action. The Outposts bucket owner has this permission by default and can grant this
        /// permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">
        /// Permissions Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
        /// access permissions to your Amazon S3 resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>PutBucketTagging</code> has the following special errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>InvalidTagError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The tag provided was not a valid tag. This error can occur if the tag
        /// did not pass input validation. For information about tag restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">
        /// User-Defined Tag Restrictions</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/aws-tag-restrictions.html">
        /// Amazon Web Services-Generated Cost Allocation Tag Restrictions</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>MalformedXMLError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The XML provided does not match the schema.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>OperationAbortedError </code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: A conflicting conditional action is currently in progress against this
        /// resource. Try again.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>InternalError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The service was unable to apply the provided tag to the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// All Amazon S3 on Outposts REST API requests for this action require an additional
        /// parameter of <code>x-amz-outpost-id</code> to be passed with the request and an S3
        /// on Outposts endpoint hostname prefix instead of <code>s3-control</code>. For an example
        /// of the request syntax for Amazon S3 on Outposts that uses the S3 on Outposts endpoint
        /// hostname prefix and the <code>x-amz-outpost-id</code> derived using the access point
        /// ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html#API_control_PutBucketTagging_Examples">Examples</a>
        /// section.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html">GetBucketTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html">DeleteBucketTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutBucketTagging">REST API Reference for PutBucketTagging Operation</seealso>
        public virtual Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutBucketTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutJobTagging


        /// <summary>
        /// Sets the supplied tag-set on an S3 Batch Operations job.
        /// 
        ///  
        /// <para>
        /// A tag is a key-value pair. You can associate S3 Batch Operations tags with any job
        /// by sending a PUT request against the tagging subresource that is associated with the
        /// job. To modify the existing tag set, you can either replace the existing tag set entirely,
        /// or make changes within the existing tag set by retrieving the existing tag set using
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>,
        /// modify that tag set, and use this action to replace the tag set with the one you modified.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
        /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>. 
        /// </para>
        ///   <note> <ul> <li> 
        /// <para>
        /// If you send this request with an empty tag set, Amazon S3 deletes the existing tag
        /// set on the Batch Operations job. If you use this method, you are charged for a Tier
        /// 1 Request (PUT). For more information, see <a href="http://aws.amazon.com/s3/pricing/">Amazon
        /// S3 pricing</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For deleting existing tags for your Batch Operations job, a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
        /// request is preferred because it achieves the same result without incurring charges.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A few things to consider about using tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon S3 limits the maximum number of tags to 50 tags per job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can associate up to 50 tags with a job as long as they have unique tag keys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A tag key can be up to 128 Unicode characters in length, and tag values can be up
        /// to 256 Unicode characters in length.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For tagging-related restrictions related to characters and encodings, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        ///  </li> </ul> </li> </ul> </note>  
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:PutJobTagging</code>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreatJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobTagging service method.</param>
        /// 
        /// <returns>The response from the PutJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyTagsException">
        /// Amazon S3 throws this exception if you have too many tags in your tag set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutJobTagging">REST API Reference for PutJobTagging Operation</seealso>
        public virtual PutJobTaggingResponse PutJobTagging(PutJobTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutJobTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobTaggingResponseUnmarshaller.Instance;

            return Invoke<PutJobTaggingResponse>(request, options);
        }


        /// <summary>
        /// Sets the supplied tag-set on an S3 Batch Operations job.
        /// 
        ///  
        /// <para>
        /// A tag is a key-value pair. You can associate S3 Batch Operations tags with any job
        /// by sending a PUT request against the tagging subresource that is associated with the
        /// job. To modify the existing tag set, you can either replace the existing tag set entirely,
        /// or make changes within the existing tag set by retrieving the existing tag set using
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>,
        /// modify that tag set, and use this action to replace the tag set with the one you modified.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
        /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>. 
        /// </para>
        ///   <note> <ul> <li> 
        /// <para>
        /// If you send this request with an empty tag set, Amazon S3 deletes the existing tag
        /// set on the Batch Operations job. If you use this method, you are charged for a Tier
        /// 1 Request (PUT). For more information, see <a href="http://aws.amazon.com/s3/pricing/">Amazon
        /// S3 pricing</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For deleting existing tags for your Batch Operations job, a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
        /// request is preferred because it achieves the same result without incurring charges.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A few things to consider about using tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon S3 limits the maximum number of tags to 50 tags per job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can associate up to 50 tags with a job as long as they have unique tag keys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A tag key can be up to 128 Unicode characters in length, and tag values can be up
        /// to 256 Unicode characters in length.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For tagging-related restrictions related to characters and encodings, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        ///  </li> </ul> </li> </ul> </note>  
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:PutJobTagging</code>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreatJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyTagsException">
        /// Amazon S3 throws this exception if you have too many tags in your tag set.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutJobTagging">REST API Reference for PutJobTagging Operation</seealso>
        public virtual Task<PutJobTaggingResponse> PutJobTaggingAsync(PutJobTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutJobTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutJobTaggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutJobTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutMultiRegionAccessPointPolicy


        /// <summary>
        /// Associates an access control policy with the specified Multi-Region Access Point.
        /// Each Multi-Region Access Point can have only one policy, so a request made to this
        /// action replaces any existing policy that is associated with the specified Multi-Region
        /// Access Point.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutMultiRegionAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicy.html">GetMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicyStatus.html">GetMultiRegionAccessPointPolicyStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMultiRegionAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the PutMultiRegionAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutMultiRegionAccessPointPolicy">REST API Reference for PutMultiRegionAccessPointPolicy Operation</seealso>
        public virtual PutMultiRegionAccessPointPolicyResponse PutMultiRegionAccessPointPolicy(PutMultiRegionAccessPointPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMultiRegionAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMultiRegionAccessPointPolicyResponseUnmarshaller.Instance;

            return Invoke<PutMultiRegionAccessPointPolicyResponse>(request, options);
        }


        /// <summary>
        /// Associates an access control policy with the specified Multi-Region Access Point.
        /// Each Multi-Region Access Point can have only one policy, so a request made to this
        /// action replaces any existing policy that is associated with the specified Multi-Region
        /// Access Point.
        /// 
        ///  
        /// <para>
        /// This action will always be routed to the US West (Oregon) Region. For more information
        /// about the restrictions around managing Multi-Region Access Points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ManagingMultiRegionAccessPoints.html">Managing
        /// Multi-Region Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to <code>PutMultiRegionAccessPointPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicy.html">GetMultiRegionAccessPointPolicy</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetMultiRegionAccessPointPolicyStatus.html">GetMultiRegionAccessPointPolicyStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMultiRegionAccessPointPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMultiRegionAccessPointPolicy service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutMultiRegionAccessPointPolicy">REST API Reference for PutMultiRegionAccessPointPolicy Operation</seealso>
        public virtual Task<PutMultiRegionAccessPointPolicyResponse> PutMultiRegionAccessPointPolicyAsync(PutMultiRegionAccessPointPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMultiRegionAccessPointPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMultiRegionAccessPointPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutMultiRegionAccessPointPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPublicAccessBlock


        /// <summary>
        /// Creates or modifies the <code>PublicAccessBlock</code> configuration for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
        /// Using Amazon S3 block public access</a>.
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetPublicAccessBlock.html">GetPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeletePublicAccessBlock.html">DeletePublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the PutPublicAccessBlock service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutPublicAccessBlock">REST API Reference for PutPublicAccessBlock Operation</seealso>
        public virtual PutPublicAccessBlockResponse PutPublicAccessBlock(PutPublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<PutPublicAccessBlockResponse>(request, options);
        }


        /// <summary>
        /// Creates or modifies the <code>PublicAccessBlock</code> configuration for an Amazon
        /// Web Services account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">
        /// Using Amazon S3 block public access</a>.
        /// 
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetPublicAccessBlock.html">GetPublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeletePublicAccessBlock.html">DeletePublicAccessBlock</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPublicAccessBlock service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutPublicAccessBlock">REST API Reference for PutPublicAccessBlock Operation</seealso>
        public virtual Task<PutPublicAccessBlockResponse> PutPublicAccessBlockAsync(PutPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPublicAccessBlockResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutPublicAccessBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutStorageLensConfiguration


        /// <summary>
        /// Puts an Amazon S3 Storage Lens configuration. For more information about S3 Storage
        /// Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Working
        /// with Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:PutStorageLensConfiguration</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStorageLensConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfiguration">REST API Reference for PutStorageLensConfiguration Operation</seealso>
        public virtual PutStorageLensConfigurationResponse PutStorageLensConfiguration(PutStorageLensConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutStorageLensConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutStorageLensConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutStorageLensConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Puts an Amazon S3 Storage Lens configuration. For more information about S3 Storage
        /// Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Working
        /// with Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:PutStorageLensConfiguration</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStorageLensConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutStorageLensConfiguration service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfiguration">REST API Reference for PutStorageLensConfiguration Operation</seealso>
        public virtual Task<PutStorageLensConfigurationResponse> PutStorageLensConfigurationAsync(PutStorageLensConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutStorageLensConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutStorageLensConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutStorageLensConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutStorageLensConfigurationTagging


        /// <summary>
        /// Put or replace tags on an existing Amazon S3 Storage Lens configuration. For more
        /// information about S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:PutStorageLensConfigurationTagging</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStorageLensConfigurationTagging service method.</param>
        /// 
        /// <returns>The response from the PutStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfigurationTagging">REST API Reference for PutStorageLensConfigurationTagging Operation</seealso>
        public virtual PutStorageLensConfigurationTaggingResponse PutStorageLensConfigurationTagging(PutStorageLensConfigurationTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutStorageLensConfigurationTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutStorageLensConfigurationTaggingResponseUnmarshaller.Instance;

            return Invoke<PutStorageLensConfigurationTaggingResponse>(request, options);
        }


        /// <summary>
        /// Put or replace tags on an existing Amazon S3 Storage Lens configuration. For more
        /// information about S3 Storage Lens, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens.html">Assessing
        /// your storage activity and usage with Amazon S3 Storage Lens </a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// To use this action, you must have permission to perform the <code>s3:PutStorageLensConfigurationTagging</code>
        /// action. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage_lens_iam_permissions.html">Setting
        /// permissions to use Amazon S3 Storage Lens</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStorageLensConfigurationTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutStorageLensConfigurationTagging service method, as returned by S3Control.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/PutStorageLensConfigurationTagging">REST API Reference for PutStorageLensConfigurationTagging Operation</seealso>
        public virtual Task<PutStorageLensConfigurationTaggingResponse> PutStorageLensConfigurationTaggingAsync(PutStorageLensConfigurationTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutStorageLensConfigurationTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutStorageLensConfigurationTaggingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutStorageLensConfigurationTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJobPriority


        /// <summary>
        /// Updates an existing S3 Batch Operations job's priority. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobPriority service method.</param>
        /// 
        /// <returns>The response from the UpdateJobPriority service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobPriority">REST API Reference for UpdateJobPriority Operation</seealso>
        public virtual UpdateJobPriorityResponse UpdateJobPriority(UpdateJobPriorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobPriorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobPriorityResponseUnmarshaller.Instance;

            return Invoke<UpdateJobPriorityResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing S3 Batch Operations job's priority. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobPriority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJobPriority service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobPriority">REST API Reference for UpdateJobPriority Operation</seealso>
        public virtual Task<UpdateJobPriorityResponse> UpdateJobPriorityAsync(UpdateJobPriorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobPriorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobPriorityResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateJobPriorityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJobStatus


        /// <summary>
        /// Updates the status for the specified job. Use this action to confirm that you want
        /// to run a job or to cancel an existing job. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateJobStatus service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.JobStatusException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobStatus">REST API Reference for UpdateJobStatus Operation</seealso>
        public virtual UpdateJobStatusResponse UpdateJobStatus(UpdateJobStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateJobStatusResponse>(request, options);
        }


        /// <summary>
        /// Updates the status for the specified job. Use this action to confirm that you want
        /// to run a job or to cancel an existing job. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-basics.html">S3
        /// Batch Operations</a> in the <i>Amazon S3 User Guide</i>.
        /// 
        ///   
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListJobs.html">ListJobs</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DescribeJob.html">DescribeJob</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_UpdateJobStatus.html">UpdateJobStatus</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJobStatus service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.JobStatusException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3control-2018-08-20/UpdateJobStatus">REST API Reference for UpdateJobStatus Operation</seealso>
        public virtual Task<UpdateJobStatusResponse> UpdateJobStatusAsync(UpdateJobStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateJobStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}