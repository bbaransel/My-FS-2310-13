import React from 'react'
import Todo from './Todo'
import TodoEditForm from './TodoEditForm'

function TodoContainer({ todos, toggleComplete, deleteTask, approval, editTodo, saveTodo }) {
    return (
        <>
            <div className='TodoContainer'>
                {
                    todos.map((todo) => {
                        if (todo.isEditing) {
                            return <TodoEditForm task={todo} saveTodo={saveTodo} key={todo.id} />
                        } else {
                            return <Todo
                                key={todo.id}
                                task={todo}
                                toggleComplete={toggleComplete}
                                deleteTask={deleteTask}
                                approval={approval}
                                editTodo={editTodo}
                            />
                        }
                    })
                }
            </div>
        </>
    )
}

export default TodoContainer