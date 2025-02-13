﻿namespace Adnc.Maint.WebApi.Controllers;

/// <summary>
/// 配置管理
/// </summary>
[Route("maint/cfgs")]
[ApiController]
public class CfgController : AdncControllerBase
{
    private readonly ICfgAppService _cfgAppService;

    public CfgController(ICfgAppService cfgAppService)
       => _cfgAppService = cfgAppService;

    /// <summary>
    /// 新增配置
    /// </summary>
    /// <param name="input"><see cref="CfgCreationDto"/></param>
    /// <returns></returns>
    [HttpPost]
    [Permission(PermissionConsts.Cfg.Create)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<long>> CreateAsync([FromBody] CfgCreationDto input)
        => CreatedResult(await _cfgAppService.CreateAsync(input));

    /// <summary>
    /// 更新配置
    /// </summary>
    /// <param name="id">id</param>
    /// <param name="input"><see cref="CfgUpdationDto"/></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    [Permission(PermissionConsts.Cfg.Update)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult<long>> UpdateAsync([FromRoute] long id, [FromBody] CfgUpdationDto input)
        => Result(await _cfgAppService.UpdateAsync(id, input));

    /// <summary>
    /// 删除配置节点
    /// </summary>
    /// <param name="id">节点id</param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    [Permission(PermissionConsts.Cfg.Delete)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult> DeleteAsync([FromRoute] long id)
        => Result(await _cfgAppService.DeleteAsync(id));

    /// <summary>
    /// 获取配置列表
    /// </summary>
    /// <param name="search"><see cref="CfgSearchPagedDto"/></param>
    /// <returns><see cref="PageModelDto{CfgDto}"/></returns>
    [HttpGet()]
    [Permission(PermissionConsts.Cfg.GetList)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<PageModelDto<CfgDto>>> GetPagedAsync([FromQuery] CfgSearchPagedDto search)
        => await _cfgAppService.GetPagedAsync(search);
}