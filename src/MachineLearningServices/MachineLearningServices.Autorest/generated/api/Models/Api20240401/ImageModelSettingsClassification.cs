// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>
    /// Settings used for training the model.
    /// For more information on the available settings please visit the official documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
    /// </summary>
    public partial class ImageModelSettingsClassification :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsClassification,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsClassificationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettings"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettings __imageModelSettings = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ImageModelSettings();

        /// <summary>Settings for advanced scenarios.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string AdvancedSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).AdvancedSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).AdvancedSetting = value ?? null; }

        /// <summary>Enable AMSGrad when optimizer is 'adam' or 'adamw'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public bool? AmsGradient { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).AmsGradient; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).AmsGradient = value ?? default(bool); }

        /// <summary>Settings for using Augmentations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Augmentation { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Augmentation; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Augmentation = value ?? null; }

        /// <summary>
        /// Value of 'beta1' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public float? Beta1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Beta1; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Beta1 = value ?? default(float); }

        /// <summary>
        /// Value of 'beta2' when optimizer is 'adam' or 'adamw'. Must be a float in the range [0, 1].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public float? Beta2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Beta2; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Beta2 = value ?? default(float); }

        /// <summary>Frequency to store model checkpoints. Must be a positive integer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? CheckpointFrequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointFrequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointFrequency = value ?? default(int); }

        /// <summary>The pretrained checkpoint model for incremental training.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMlFlowModelJobInput CheckpointModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModel; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModel = value ?? null /* model class */; }

        /// <summary>Description for the input.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string CheckpointModelDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModelDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModelDescription = value ?? null; }

        /// <summary>[Required] Specifies the type of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType? CheckpointModelJobInputType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModelJobInputType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModelJobInputType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobInputType)""); }

        /// <summary>Input Asset Delivery Mode.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.InputDeliveryMode? CheckpointModelMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModelMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModelMode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.InputDeliveryMode)""); }

        /// <summary>[Required] Input Asset URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string CheckpointModelUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModelUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointModelUri = value ?? null; }

        /// <summary>
        /// The id of a previous run that has a pretrained checkpoint for incremental training.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string CheckpointRunId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointRunId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).CheckpointRunId = value ?? null; }

        /// <summary>Whether to use distributed training.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public bool? Distributed { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Distributed; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Distributed = value ?? default(bool); }

        /// <summary>Enable early stopping logic during training.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public bool? EarlyStopping { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EarlyStopping; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EarlyStopping = value ?? default(bool); }

        /// <summary>
        /// Minimum number of epochs or validation evaluations to wait before primary metric improvement
        /// is tracked for early stopping. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? EarlyStoppingDelay { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EarlyStoppingDelay; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EarlyStoppingDelay = value ?? default(int); }

        /// <summary>
        /// Minimum number of epochs or validation evaluations with no primary metric improvement before
        /// the run is stopped. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? EarlyStoppingPatience { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EarlyStoppingPatience; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EarlyStoppingPatience = value ?? default(int); }

        /// <summary>Enable normalization when exporting ONNX model.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public bool? EnableOnnxNormalization { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EnableOnnxNormalization; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EnableOnnxNormalization = value ?? default(bool); }

        /// <summary>
        /// Frequency to evaluate validation dataset to get metric scores. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? EvaluationFrequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EvaluationFrequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).EvaluationFrequency = value ?? default(int); }

        /// <summary>
        /// Gradient accumulation means running a configured number of "GradAccumulationStep" steps without
        /// updating the model weights while accumulating the gradients of those steps, and then using
        /// the accumulated gradients to compute the weight updates. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? GradientAccumulationStep { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).GradientAccumulationStep; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).GradientAccumulationStep = value ?? default(int); }

        /// <summary>
        /// Number of layers to freeze for the model. Must be a positive integer.
        /// For instance, passing 2 as value for 'seresnext' means
        /// freezing layer0 and layer1. For a full list of models supported and details on layer freeze, please
        /// see: https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? LayersToFreeze { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).LayersToFreeze; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).LayersToFreeze = value ?? default(int); }

        /// <summary>Initial learning rate. Must be a float in the range [0, 1].</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public float? LearningRate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).LearningRate; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).LearningRate = value ?? default(float); }

        /// <summary>Type of learning rate scheduler. Must be 'warmup_cosine' or 'step'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LearningRateScheduler? LearningRateScheduler { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).LearningRateScheduler; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).LearningRateScheduler = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.LearningRateScheduler)""); }

        /// <summary>
        /// Name of the model to use for training.
        /// For more information on the available models please visit the official documentation:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string ModelName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).ModelName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).ModelName = value ?? null; }

        /// <summary>Value of momentum when optimizer is 'sgd'. Must be a float in the range [0, 1].</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public float? Momentum { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Momentum; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Momentum = value ?? default(float); }

        /// <summary>Enable nesterov when optimizer is 'sgd'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public bool? Nesterov { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Nesterov; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Nesterov = value ?? default(bool); }

        /// <summary>Number of training epochs. Must be a positive integer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? NumberOfEpoch { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).NumberOfEpoch; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).NumberOfEpoch = value ?? default(int); }

        /// <summary>Number of data loader workers. Must be a non-negative integer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? NumberOfWorker { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).NumberOfWorker; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).NumberOfWorker = value ?? default(int); }

        /// <summary>Type of optimizer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.StochasticOptimizer? Optimizer { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Optimizer; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).Optimizer = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.StochasticOptimizer)""); }

        /// <summary>Random seed to be used when using deterministic training.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? RandomSeed { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).RandomSeed; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).RandomSeed = value ?? default(int); }

        /// <summary>
        /// Value of gamma when learning rate scheduler is 'step'. Must be a float in the range [0, 1].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public float? StepLrGamma { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).StepLrGamma; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).StepLrGamma = value ?? default(float); }

        /// <summary>
        /// Value of step size when learning rate scheduler is 'step'. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? StepLrStepSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).StepLrStepSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).StepLrStepSize = value ?? default(int); }

        /// <summary>Training batch size. Must be a positive integer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? TrainingBatchSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).TrainingBatchSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).TrainingBatchSize = value ?? default(int); }

        /// <summary>Backing field for <see cref="TrainingCropSize" /> property.</summary>
        private int? _trainingCropSize;

        /// <summary>
        /// Image crop size that is input to the neural network for the training dataset. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? TrainingCropSize { get => this._trainingCropSize; set => this._trainingCropSize = value; }

        /// <summary>Validation batch size. Must be a positive integer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? ValidationBatchSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).ValidationBatchSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).ValidationBatchSize = value ?? default(int); }

        /// <summary>Backing field for <see cref="ValidationCropSize" /> property.</summary>
        private int? _validationCropSize;

        /// <summary>
        /// Image crop size that is input to the neural network for the validation dataset. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? ValidationCropSize { get => this._validationCropSize; set => this._validationCropSize = value; }

        /// <summary>Backing field for <see cref="ValidationResizeSize" /> property.</summary>
        private int? _validationResizeSize;

        /// <summary>
        /// Image size to which to resize before cropping for validation dataset. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? ValidationResizeSize { get => this._validationResizeSize; set => this._validationResizeSize = value; }

        /// <summary>
        /// Value of cosine cycle when learning rate scheduler is 'warmup_cosine'. Must be a float in the range [0, 1].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public float? WarmupCosineLrCycle { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).WarmupCosineLrCycle; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).WarmupCosineLrCycle = value ?? default(float); }

        /// <summary>
        /// Value of warmup epochs when learning rate scheduler is 'warmup_cosine'. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public int? WarmupCosineLrWarmupEpoch { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).WarmupCosineLrWarmupEpoch; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).WarmupCosineLrWarmupEpoch = value ?? default(int); }

        /// <summary>
        /// Value of weight decay when optimizer is 'sgd', 'adam', or 'adamw'. Must be a float in the range[0, 1].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public float? WeightDecay { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).WeightDecay; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal)__imageModelSettings).WeightDecay = value ?? default(float); }

        /// <summary>Backing field for <see cref="WeightedLoss" /> property.</summary>
        private int? _weightedLoss;

        /// <summary>
        /// Weighted loss. The accepted values are 0 for no weighted loss.
        /// 1 for weighted loss with sqrt.(class_weights). 2 for weighted loss with class_weights. Must be 0 or 1 or 2.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? WeightedLoss { get => this._weightedLoss; set => this._weightedLoss = value; }

        /// <summary>Creates an new <see cref="ImageModelSettingsClassification" /> instance.</summary>
        public ImageModelSettingsClassification()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__imageModelSettings), __imageModelSettings);
            await eventListener.AssertObjectIsValid(nameof(__imageModelSettings), __imageModelSettings);
        }
    }
    /// Settings used for training the model.
    /// For more information on the available settings please visit the official documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
    public partial interface IImageModelSettingsClassification :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettings
    {
        /// <summary>
        /// Image crop size that is input to the neural network for the training dataset. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Image crop size that is input to the neural network for the training dataset. Must be a positive integer.",
        SerializedName = @"trainingCropSize",
        PossibleTypes = new [] { typeof(int) })]
        int? TrainingCropSize { get; set; }
        /// <summary>
        /// Image crop size that is input to the neural network for the validation dataset. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Image crop size that is input to the neural network for the validation dataset. Must be a positive integer.",
        SerializedName = @"validationCropSize",
        PossibleTypes = new [] { typeof(int) })]
        int? ValidationCropSize { get; set; }
        /// <summary>
        /// Image size to which to resize before cropping for validation dataset. Must be a positive integer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Image size to which to resize before cropping for validation dataset. Must be a positive integer.",
        SerializedName = @"validationResizeSize",
        PossibleTypes = new [] { typeof(int) })]
        int? ValidationResizeSize { get; set; }
        /// <summary>
        /// Weighted loss. The accepted values are 0 for no weighted loss.
        /// 1 for weighted loss with sqrt.(class_weights). 2 for weighted loss with class_weights. Must be 0 or 1 or 2.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Weighted loss. The accepted values are 0 for no weighted loss.
        1 for weighted loss with sqrt.(class_weights). 2 for weighted loss with class_weights. Must be 0 or 1 or 2.",
        SerializedName = @"weightedLoss",
        PossibleTypes = new [] { typeof(int) })]
        int? WeightedLoss { get; set; }

    }
    /// Settings used for training the model.
    /// For more information on the available settings please visit the official documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
    internal partial interface IImageModelSettingsClassificationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IImageModelSettingsInternal
    {
        /// <summary>
        /// Image crop size that is input to the neural network for the training dataset. Must be a positive integer.
        /// </summary>
        int? TrainingCropSize { get; set; }
        /// <summary>
        /// Image crop size that is input to the neural network for the validation dataset. Must be a positive integer.
        /// </summary>
        int? ValidationCropSize { get; set; }
        /// <summary>
        /// Image size to which to resize before cropping for validation dataset. Must be a positive integer.
        /// </summary>
        int? ValidationResizeSize { get; set; }
        /// <summary>
        /// Weighted loss. The accepted values are 0 for no weighted loss.
        /// 1 for weighted loss with sqrt.(class_weights). 2 for weighted loss with class_weights. Must be 0 or 1 or 2.
        /// </summary>
        int? WeightedLoss { get; set; }

    }
}