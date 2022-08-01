namespace pilipala.container.post

open System
open fsharper.op.Alias
open fsharper.typ

type IPost =
    abstract Id: u64
    abstract Title: string with get, set
    abstract Body: string with get, set
    abstract CreateTime: DateTime with get, set
    abstract AccessTime: DateTime with get, set
    abstract ModifyTime: DateTime with get, set
    abstract Item: string -> Option'<obj> with get, set

type IPostProvider =
    abstract fetch: u64 -> IPost
    abstract create: IPost -> u64
    abstract delete: u64 -> u64 * IPost
