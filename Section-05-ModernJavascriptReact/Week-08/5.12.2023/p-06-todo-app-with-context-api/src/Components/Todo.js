import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext'

const Todo = ({ task }) => {
    const context = useContext(TodoContext)
    return (
        <>
            <li className={task.isComplated ? "list-group-item rounded-2 mb-2 bg-success bg-gradient text-decoration-line-through d-flex justify-content-between" : "bg-gradient list-group-item rounded-2 mb-2 d-flex justify-content-between"} >
                <div onClick={() => context.toggleComplete(task.id)} className='btn text-start col-11' >{task.desc}</div>
                <div className='col-1 d-flex justify-content-around'>
                    <button className='btn btn-warning btn-md' onClick={() => context.toggleEditing(task.id)} ><i class="fa-solid fa-pen-to-square"></i></button>
                    <button className='btn btn-danger btn-md' onClick={() => context.approval(task.id)}><i class="fa-solid fa-trash"></i></button>
                </div>
            </li>
        </>
    )
}

export default Todo;