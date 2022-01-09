namespace SimpleGltf.Json.Extensions;

public static class AnimationExtensions
{
    public static Channel CreateChannel(this Animation animation, AnimationSampler sampler,
        Target target)
    {
        return new Channel(animation, sampler, target);
    }

    public static AnimationSampler CreateSampler(this Animation animation, FloatAccessor input,
        FloatAccessor output)
    {
        return new AnimationSampler(animation, input, output);
    }
}