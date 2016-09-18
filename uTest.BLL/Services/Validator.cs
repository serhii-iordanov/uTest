﻿using uTest.BLL.DTO;
using uTest.BLL.Infrastructure;

namespace uTest.BLL.Services
{
    public static class Validator
    {
        public static void ValidateTestModel(TestDTO testDto)
        {
            if (testDto == null)
                throw new ValidationException("Cannot create test from null", "");
            if (string.IsNullOrEmpty(testDto.Name))
                throw new ValidationException("This property cannot be empty", "Name");
            if (testDto.Questions == null || testDto.Questions.Count == 0)
                throw new ValidationException("Test must contain at least one question", "");
        }

        public static void ValidateQuestionModel(QuestionDTO questionDto)
        {          
            if (questionDto == null)
                throw new ValidationException("Cannot create question from null", "");
            if (questionDto.Text == null)
                throw new ValidationException("This property cannot be null", "Text");
            if (questionDto.Answers == null || questionDto.Answers.Count == 0)
                throw new ValidationException("Questtion must contain at least one answer", "");
        }

        public static void ValidateAnswerModel(AnswerDTO answerDto)
        {
            if (answerDto == null)
                throw new ValidationException("Cannot create answer from empty", "");
            if (answerDto.Text == null)
                throw new ValidationException("This property cannot be empty", "Text");
        }

        public static void ValidateTaskModel(TaskDTO taskDto)
        {
            if (taskDto == null)
                throw new ValidationException("Cannot create task from empty", "");
            if (string.IsNullOrEmpty(taskDto.UserId))
                throw new ValidationException("This property cannot be empty", "UserId");
        }
    }
}
